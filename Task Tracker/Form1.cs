﻿using System;
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
    public partial class Form1 : Form
    {
        DBOperations db = new DBOperations();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskTrackerDataSet.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.taskTrackerDataSet.Task);

        }

        public void UpdateGridView()
        {
           // this.taskTrackerDataSet.Clear();
           // DataSet ds = db.getTaskDataSet();

           // this.dataGridView1.DataSource = null;
           // //dataGridView1.DataSource = ds;
           //// dataGridView1.Update();
           // //dataGridView1.Refresh();
           // //IDataAdapter da;
           // //da.Fill(taskTrackerDataSet);
            
           // this.Refresh();
        }
    }
}