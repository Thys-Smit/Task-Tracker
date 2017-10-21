using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Task_Tracker
{
    public partial class frmProjectTracker : Form
    {
        DBOperations db = new DBOperations();

        public frmProjectTracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'applicationsDataSet.ActiveApplications' table. You can move, or remove it, as needed.
            this.activeApplicationsTableAdapter.Fill(this.applicationsDataSet.ActiveApplications);
            lbxActiveApps.ClearSelected();
            // TODO: This line of code loads data into the 'applicationsDataSet.InactiveApplications' table. You can move, or remove it, as needed.
            this.inactiveApplicationsTableAdapter.Fill(this.applicationsDataSet.InactiveApplications);
            lbxAvailableApps.ClearSelected();
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.taskTrackerDataSet.Task);
        }

        /// <summary>
        /// Refresh the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshGridView(object sender, EventArgs e)
        {
            this.taskTableAdapter.Fill(this.taskTrackerDataSet.Task);
        }

        /// <summary>
        /// Refresh the application listboxes
        /// </summary>
        private void RefreshListBoxes()
        {
            inactiveApplicationsTableAdapter.Fill(applicationsDataSet.InactiveApplications);
            activeApplicationsTableAdapter.Fill(applicationsDataSet.ActiveApplications);
            lbxActiveApps.ClearSelected();
            lbxAvailableApps.ClearSelected();
        }

        /// <summary>
        /// Change the application isActive state to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeApplicationActive(object sender, EventArgs e)
        {
            string strAppName = lbxAvailableApps.GetItemText(lbxAvailableApps.SelectedItem);
            db.makeApplicationActive(strAppName);
            RefreshListBoxes();
        }

        /// <summary>
        /// Change the application isActive state to false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeApplicationInactive(object sender, EventArgs e)
        {
            string strAppName = lbxActiveApps.GetItemText(lbxActiveApps.SelectedItem);
            db.makeApplicationInactive(strAppName);
            RefreshListBoxes();
        }

        /// <summary>
        /// Add an application to the application table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addApplication(object sender, EventArgs e)
        {
            string strAppName = tbAddApp.Text.ToString();
            db.addApplication(strAppName);
            RefreshListBoxes();
            tbAddApp.Clear();
        }


    }
}
