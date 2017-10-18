namespace Task_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTrackerDataSet = new Task_Tracker.TaskTrackerDataSet();
            this.taskTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.TaskTableAdapter();
            this.iDTaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSessionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSessionEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Refresh);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Refresh);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTaskDataGridViewTextBoxColumn,
            this.applicationDataGridViewTextBoxColumn,
            this.currentSessionStartDataGridViewTextBoxColumn,
            this.currentSessionEndDataGridViewTextBoxColumn,
            this.totalTimeDataGridViewTextBoxColumn,
            this.timeSpanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(964, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.taskTrackerDataSet;
            // 
            // taskTrackerDataSet
            // 
            this.taskTrackerDataSet.DataSetName = "TaskTrackerDataSet";
            this.taskTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // iDTaskDataGridViewTextBoxColumn
            // 
            this.iDTaskDataGridViewTextBoxColumn.DataPropertyName = "IDTask";
            this.iDTaskDataGridViewTextBoxColumn.HeaderText = "IDTask";
            this.iDTaskDataGridViewTextBoxColumn.Name = "iDTaskDataGridViewTextBoxColumn";
            this.iDTaskDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicationDataGridViewTextBoxColumn
            // 
            this.applicationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.applicationDataGridViewTextBoxColumn.DataPropertyName = "Application";
            this.applicationDataGridViewTextBoxColumn.HeaderText = "Application";
            this.applicationDataGridViewTextBoxColumn.Name = "applicationDataGridViewTextBoxColumn";
            this.applicationDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationDataGridViewTextBoxColumn.Width = 84;
            // 
            // currentSessionStartDataGridViewTextBoxColumn
            // 
            this.currentSessionStartDataGridViewTextBoxColumn.DataPropertyName = "CurrentSessionStart";
            dataGridViewCellStyle1.Format = "T";
            dataGridViewCellStyle1.NullValue = null;
            this.currentSessionStartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.currentSessionStartDataGridViewTextBoxColumn.HeaderText = "CurrentSessionStart";
            this.currentSessionStartDataGridViewTextBoxColumn.Name = "currentSessionStartDataGridViewTextBoxColumn";
            this.currentSessionStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentSessionEndDataGridViewTextBoxColumn
            // 
            this.currentSessionEndDataGridViewTextBoxColumn.DataPropertyName = "CurrentSessionEnd";
            dataGridViewCellStyle2.Format = "T";
            dataGridViewCellStyle2.NullValue = null;
            this.currentSessionEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.currentSessionEndDataGridViewTextBoxColumn.HeaderText = "CurrentSessionEnd";
            this.currentSessionEndDataGridViewTextBoxColumn.Name = "currentSessionEndDataGridViewTextBoxColumn";
            this.currentSessionEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalTimeDataGridViewTextBoxColumn
            // 
            this.totalTimeDataGridViewTextBoxColumn.DataPropertyName = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.HeaderText = "TotalTime";
            this.totalTimeDataGridViewTextBoxColumn.Name = "totalTimeDataGridViewTextBoxColumn";
            this.totalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeSpanDataGridViewTextBoxColumn
            // 
            this.timeSpanDataGridViewTextBoxColumn.DataPropertyName = "TimeSpan";
            dataGridViewCellStyle3.NullValue = null;
            this.timeSpanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.timeSpanDataGridViewTextBoxColumn.HeaderText = "TimeSpan";
            this.timeSpanDataGridViewTextBoxColumn.Name = "timeSpanDataGridViewTextBoxColumn";
            this.timeSpanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 283);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TaskTrackerDataSet taskTrackerDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private TaskTrackerDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentSessionStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentSessionEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpanDataGridViewTextBoxColumn;
    }
}

