﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace Task_Tracker
{
    class DBOperations
    {
        #region Declarations
        SqlConnection conn = new SqlConnection();
        //TODO : Get connection string from AppData
        string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TaskTracker; Integrated Security = True";
        #endregion

        #region Database Connection
        /// <summary>
        /// Test the connection to the database
        /// </summary>
        /// <param name="connString"></param>
        /// <returns></returns>
        public bool testDBConnection(string connString)
        {
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (SqlException ex)
            {
                // output the error to see what's going on
                MessageBox.Show("The connection to the database could not be made. \n\nCheck the connection before trying to continue.\n\n" + ex.Message);
                return false;
            }
        }

        /// <summary>
        ///  Connect to database
        /// </summary>
        /// <param name="connString"></param>
        /// <returns></returns>
        public bool connectToDB(string connString)
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.ConnectionString = connString;
            }
            else return true;
            
            if (testDBConnection(connString))
            {
                conn.Open();
                return true;
            }
            else return false;
            
        }

        /// <summary>
        /// //Close database connection
        /// </summary>
        public void closeDBConn()
        {
            conn.Close();
        }

        #endregion

        #region Project File Tracking Logic & Validation

        public string getApplicationTitle(string strTitle)
        {
            string strAppName;
            SqlCommand selectCommand = new SqlCommand
            (
                "SELECT ApplicationName FROM Applications WHERE Inactive = 0", conn
            );

            try
            {
                selectCommand.ExecuteNonQuery();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    strAppName = reader.GetString(0);

                    if (strTitle.Contains(strAppName))
                    {
                        reader.Close();
                        return strAppName;
                    }
                };

                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                closeDBConn();
                return null;
            }
            finally
            {
                //conn.Close();
            }
            return null;
        }

        public void insertNewTask(string strTitle, DateTime currentStartTime)
        {
            
            //Insert SQL Command
            SqlCommand insertCommand = new SqlCommand
            (
                "INSERT INTO Task (Application, CurrentSessionStart) VALUES (@strTitle, @currentStartTime)", conn
            );
            //Add Params
            insertCommand.Parameters.Add(new SqlParameter("strTitle", strTitle));
            insertCommand.Parameters.Add(new SqlParameter("currentStartTime", currentStartTime));

            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return;
            }
            finally
            {
                //conn.Close();
            }
        }

        public bool isValidApplication(string strTitle)
        {

            //Select SQL Command 
            SqlCommand selectStatement = new SqlCommand
            (
                "SELECT Count(IDApplication) FROM Applications WHERE ApplicationName LIKE @strTitle AND isActive = 1", conn
            );
            //Add Params
            selectStatement.Parameters.Add(new SqlParameter("strTitle", "%" + strTitle + "%"));

            try
            {
                selectStatement.ExecuteNonQuery();
                SqlDataReader reader = selectStatement.ExecuteReader();
                reader.Read();
                
                if (reader.GetInt32(0) > 0)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
            finally
            {
                //conn.Close();
            }
        }

        public bool isTaskMatch(string strTitle)
        {
            //conn.Open();

            //Select SQL Command 
            SqlCommand selectStatement = new SqlCommand
            (
                "SELECT Count(Application) FROM Task WHERE Application = @strTitle", conn
            );
            //Add Params
            selectStatement.Parameters.Add(new SqlParameter("strTitle", strTitle));

            try
            {
                selectStatement.ExecuteNonQuery();
                SqlDataReader reader = selectStatement.ExecuteReader();
                reader.Read();

                if (reader.GetInt32(0) > 0)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return false;
            }
        }

        public void updateExistingTask_StartTime(string strTitle, DateTime currentStartTime)
        {
            //conn.Open();

            //Update SQL Command
            SqlCommand updateCommand = new SqlCommand
            (
                "UPDATE Task SET CurrentSessionStart = @currentStartTime WHERE Application = @strTitle", conn
            );
            //Add Params
            updateCommand.Parameters.Add(new SqlParameter("strTitle", strTitle));
            updateCommand.Parameters.Add(new SqlParameter("currentStartTime", currentStartTime));

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conn.Close();
            }

        }

        public void updateExistingTask_EndTime(string strTitle, DateTime currentEndTime)
        {
            //conn.Open();
            SqlCommand updateCommand = new SqlCommand
            (
                "UPDATE Task SET CurrentSessionEnd = @currentEndTime WHERE Application = @strTitle", conn
            );
            //Add Params
            updateCommand.Parameters.Add(new SqlParameter("strTitle", strTitle));
            updateCommand.Parameters.Add(new SqlParameter("currentEndTime", currentEndTime));

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conn.Close();
            }
           
        }

        public void updateExistingTask_TotalTime(string strTitle, DateTime totalTime)
        {
            //conn.Open();

            Int64 duration = getTimeSpan(strTitle);
            TimeSpan timeSpan = TimeSpan.FromTicks(duration);
            
            //Update SQL Command
            SqlCommand updateCommand = new SqlCommand
            (             
                "UPDATE Task SET TotalTime = @totalTime, TimeSpan = @timeSpan WHERE Application = @strTitle", conn
            );
            //Add Params
            updateCommand.Parameters.Add(new SqlParameter("strTitle", strTitle));
            updateCommand.Parameters.Add(new SqlParameter("totalTime", duration));
            updateCommand.Parameters.Add(new SqlParameter("timeSpan", timeSpan));

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //conn.Close();
            }

        }

        private Int64 getTimeSpan(string strTitle)
        {

            DateTime currentStart;
            DateTime currentEnd;
            Int64 totalTime = 0;
            Int64 duration;

            //Select SQL command
            SqlCommand selectStatement = new SqlCommand
            (
                "SELECT CurrentSessionStart, CurrentSessionEnd, TotalTime FROM Task WHERE Application = @strTitle", conn
            );
            //Add Params
            selectStatement.Parameters.Add(new SqlParameter("strTitle", strTitle));

            try
            {
                selectStatement.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            SqlDataReader reader = selectStatement.ExecuteReader();
            if (reader.Read())
            {

                currentStart = reader.GetDateTime(0);
                currentEnd = reader.GetDateTime(1);
                duration = currentEnd.Ticks - currentStart.Ticks;

                if (reader.IsDBNull(2))
                {
                    totalTime = duration;
                }
                else
                {
                    totalTime = reader.GetInt64(2);
                }

                Debug.Print("Before :" + TimeSpan.FromTicks(totalTime));
                totalTime = totalTime + duration;
                Debug.Print("After :" + TimeSpan.FromTicks(totalTime));
                reader.Close();
                return totalTime;
            }
            else
            {
                reader.Close();
                MessageBox.Show("There was no results returned from the query, there might be a data error");
                Int64 noValue = 0;
                return noValue;
            }

        }

        #endregion

        #region Application Table Logic & Validation

        /// <summary>
        /// Add a new application to the Applications DB
        /// </summary>
        /// <param name="strAppName"></param>
        public void addApplication(string strAppName)
        {
            connectToDB(connString);

            //Update SQL Command
            SqlCommand insertCommand = new SqlCommand
            (
                "IF NOT EXISTS(SELECT ApplicationName FROM Applications WHERE ApplicationName = @strAppName) " +
                "BEGIN " +
                "INSERT INTO Applications VALUES(@strAppName, 0, null, 0) " +
                "END " +
                "ELSE " +
                "BEGIN " +
                    "RAISERROR('The application name you are trying to add already exists', 16, 1) " +
                "END", conn
            );
            //Add Params
            insertCommand.Parameters.Add(new SqlParameter("strAppName", strAppName));
            

            try
            {
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeDBConn();
            }
        }

        /// <summary>
        /// Change the application isActive state to true to allow the tracker to track it.
        /// </summary>
        /// <param name="strAppName"></param>
        public void makeApplicationActive(string strAppName)
        {
            connectToDB(connString);

            //Update SQL Command
            SqlCommand updateCommand = new SqlCommand
            (
                "UPDATE Applications SET isActive = 1 WHERE ApplicationName = @strAppName", conn
            );
            //Add Params
            updateCommand.Parameters.Add(new SqlParameter("strAppName", strAppName));

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeDBConn();
            }
        }

        /// <summary>
        /// Change the application isActive state to false. The tracker will then ignore this application.
        /// </summary>
        /// <param name="strAppName"></param>
        public void makeApplicationInactive(string strAppName)
        {
            connectToDB(connString);

            //Update SQL Command
            SqlCommand updateCommand = new SqlCommand
            (
                "UPDATE Applications SET isActive = 0 WHERE ApplicationName = @strAppName", conn
            );
            //Add Params
            updateCommand.Parameters.Add(new SqlParameter("strAppName", strAppName));

            try
            {
                updateCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeDBConn();
            }
        }
        #endregion
    }
}

