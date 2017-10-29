using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace Task_Tracker
{
    class CoreOperations
    {
        #region Declarations
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        System.Timers.Timer aTimer = new System.Timers.Timer();

        DBOperations db = new DBOperations();

        //TODO : Get connection string from AppData
        string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TaskTracker; Integrated Security = True";

        string strPreviousTitle;
        string strPreviousApplication;
        #endregion

        #region Events

        /// <summary>
        /// Project File Tracking Logic
        /// Specify what you want to happen when the Elapsed event is raised.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string strTitle = GetActiveWindowTitle();
            string strApplication;

            //Open the DB Connection
            if (!db.connectToDB(connString))
            {
                stopTimer();
                return;
            }
            else if (strTitle != null)
            {

                //TODO :Impliment advanced regex filtering to determine the application name correctly. The current string manipulation caters for a specific scenario.
                //The idea will be to enable the users to manualy link a regex pattern to a application to enable the program to extract the application name from the window caption.
                strApplication = db.getApplicationTitle(strTitle);
               
                //This is the logic to determine the following:
                //Is it a brand new task - Then insert a new task into the Task table.
                //Is it a new session of a existing task - Then update the start time and end time.
                //Is it the same task as in the previous interval - Then only update the endtime of this task.
                //Note : When a new task is active (be it a brand new task or a new session of a existing task) the previous task's total time should be updated. 
                if (strPreviousTitle != strTitle)
                { 
                    if (strApplication != null && db.isValidApplication(strApplication) && !db.isTaskMatch(strTitle)) //New Task
                    {
                        db.insertNewTask(strTitle, DateTime.Now);
                        db.updateExistingTask_EndTime(strTitle, DateTime.Now);
                    }
                    else  
                    {
                        if (strPreviousTitle != null && strPreviousApplication != null && db.isValidApplication(strPreviousApplication) && db.isTaskMatch(strPreviousTitle)) //Update previous task total time
                        {
                            db.updateExistingTask_EndTime(strPreviousTitle, DateTime.Now);
                            db.updateExistingTask_TotalTime(strPreviousTitle, DateTime.Now);
                        }

                        if (db.isValidApplication(strApplication) && db.isTaskMatch(strTitle))
                        {
                            db.updateExistingTask_StartTime(strTitle, DateTime.Now);
                            db.updateExistingTask_EndTime(strTitle, DateTime.Now);
                        }
                    }
                    
                    strPreviousTitle = strTitle;
                    strPreviousApplication = strApplication;
                }
                else if (db.isValidApplication(strApplication) && db.isTaskMatch(strTitle)) //Same task as a second ago
                {
                    db.updateExistingTask_EndTime(strTitle, DateTime.Now);
                    strPreviousTitle = strTitle;
                }

                //Close the DB Connection and restart the timer.
                db.closeDBConn();
                startTimer();
            }

        }

        #endregion

        /// <summary>
        /// Get active window title.
        /// </summary>
        /// <returns></returns>
        public string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                Debug.Print(Buff.ToString());
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// Start the timer loop
        /// </summary>
        public void startTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 1000;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        /// <summary>
        /// Stop the timer loop
        /// </summary>
        public void stopTimer()
        {
            aTimer.Stop();
        }

    }
        
}

