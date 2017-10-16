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

        Form1 mainForm = new Form1();

        DBOperations db = new DBOperations();

        string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TaskTracker; Integrated Security = True";

        string strPreviousTitle;
        string strPreviousApplication;
        #endregion

        #region Events

        // Specify what you want to happen when the Elapsed event is raised.
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string strTitle = GetActiveWindowTitle();
            string strApplication;

            if (!db.connectToDB(connString))
            {
                stopTimer();
            }
            else
            {
                try
                {
                    var splitTitle = strTitle.Split('-');
                    strApplication = splitTitle[1].Trim();
                }
                catch
                {
                    strApplication = strTitle;
                }

                if (strPreviousTitle != strTitle)
                { 
                    if (db.isValidApplication(strApplication) && !db.isTaskMatch(strTitle))
                    {
                        db.insertNewTask(strTitle, DateTime.Now);
                    }
                    else if (strPreviousTitle != null && strPreviousApplication != null && db.isValidApplication(strPreviousApplication) && db.isTaskMatch(strPreviousTitle)) 
                    {
                        db.updateExistingTask_EndTime(strPreviousTitle, DateTime.Now);
                        db.updateExistingTask_TotalTime(strPreviousTitle, DateTime.Now);                       
                    }
                    else if (db.isValidApplication(strApplication) && db.isTaskMatch(strTitle))
                    {
                        db.updateExistingTask_StartTime(strTitle, DateTime.Now); 
                    }
                    strPreviousTitle = strTitle;
                    strPreviousApplication = strApplication;
                }
                else if (db.isValidApplication(strApplication) && db.isTaskMatch(strTitle))
                {
                    db.updateExistingTask_EndTime(strTitle, DateTime.Now);
                    strPreviousTitle = strTitle;
                }
            
                startTimer();
            }

        }

        #endregion

        // Get active window title.
        public string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        //Start the timer loop
        public void startTimer()
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 2000;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        //Stop the timer loop
        public void stopTimer()
        {
            aTimer.Stop();
        }

    }
        
}

