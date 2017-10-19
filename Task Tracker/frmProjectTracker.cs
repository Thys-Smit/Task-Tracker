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
            // TODO: This line of code loads data into the 'applicationsDataSet.InactiveApplications' table. You can move, or remove it, as needed.
            this.inactiveApplicationsTableAdapter.Fill(this.applicationsDataSet.InactiveApplications);

            // TODO: This line of code loads data into the 'taskTrackerDataSet.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.taskTrackerDataSet.Task);

        }

        private void Refresh(object sender, EventArgs e)
        {
            this.taskTableAdapter.Fill(this.taskTrackerDataSet.Task);
        }

       
    }
}
