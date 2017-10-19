namespace Task_Tracker
{
    partial class frmProjectTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSessionStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSessionEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeSpanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTrackerDataSet = new Task_Tracker.TaskTrackerDataSet();
            this.taskTableAdapter = new Task_Tracker.TaskTrackerDataSetTableAdapters.TaskTableAdapter();
            this.chbxStartStop = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.applicationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsDataSet = new Task_Tracker.applicationsDataSet();
            this.activeApplicationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inactiveApplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationsDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inactiveApplicationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inactiveApplicationsTableAdapter = new Task_Tracker.applicationsDataSetTableAdapters.InactiveApplicationsTableAdapter();
            this.activeApplicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activeApplicationsTableAdapter = new Task_Tracker.applicationsDataSetTableAdapters.ActiveApplicationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeApplicationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveApplicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveApplicationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeApplicationsBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 230);
            this.dataGridView1.TabIndex = 2;
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
            dataGridViewCellStyle7.Format = "T";
            dataGridViewCellStyle7.NullValue = null;
            this.currentSessionStartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.currentSessionStartDataGridViewTextBoxColumn.HeaderText = "CurrentSessionStart";
            this.currentSessionStartDataGridViewTextBoxColumn.Name = "currentSessionStartDataGridViewTextBoxColumn";
            this.currentSessionStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentSessionEndDataGridViewTextBoxColumn
            // 
            this.currentSessionEndDataGridViewTextBoxColumn.DataPropertyName = "CurrentSessionEnd";
            dataGridViewCellStyle8.Format = "T";
            dataGridViewCellStyle8.NullValue = null;
            this.currentSessionEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.NullValue = null;
            this.timeSpanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.timeSpanDataGridViewTextBoxColumn.HeaderText = "TimeSpan";
            this.timeSpanDataGridViewTextBoxColumn.Name = "timeSpanDataGridViewTextBoxColumn";
            this.timeSpanDataGridViewTextBoxColumn.ReadOnly = true;
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
            // chbxStartStop
            // 
            this.chbxStartStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbxStartStop.Location = new System.Drawing.Point(12, 12);
            this.chbxStartStop.Name = "chbxStartStop";
            this.chbxStartStop.Size = new System.Drawing.Size(77, 23);
            this.chbxStartStop.TabIndex = 4;
            this.chbxStartStop.Text = "Stop";
            this.chbxStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbxStartStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(95, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 262);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1079, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tracker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.activeApplicationsBindingSource;
            this.listBox2.DisplayMember = "ApplicationName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(301, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(209, 199);
            this.listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.inactiveApplicationsBindingSource1;
            this.listBox1.DisplayMember = "ApplicationName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 199);
            this.listBox1.TabIndex = 0;
            // 
            // applicationsDataSet
            // 
            this.applicationsDataSet.DataSetName = "applicationsDataSet";
            this.applicationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Refresh);
            // 
            // inactiveApplicationsBindingSource1
            // 
            this.inactiveApplicationsBindingSource1.DataMember = "InactiveApplications";
            this.inactiveApplicationsBindingSource1.DataSource = this.applicationsDataSet;
            // 
            // inactiveApplicationsTableAdapter
            // 
            this.inactiveApplicationsTableAdapter.ClearBeforeFill = true;
            // 
            // activeApplicationsBindingSource
            // 
            this.activeApplicationsBindingSource.DataMember = "ActiveApplications";
            this.activeApplicationsBindingSource.DataSource = this.applicationsDataSet;
            // 
            // activeApplicationsTableAdapter
            // 
            this.activeApplicationsTableAdapter.ClearBeforeFill = true;
            // 
            // frmProjectTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 279);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chbxStartStop);
            this.Controls.Add(this.button1);
            this.Name = "frmProjectTracker";
            this.Text = "Project Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskTrackerDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeApplicationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveApplicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveApplicationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeApplicationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TaskTrackerDataSet taskTrackerDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private TaskTrackerDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentSessionStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentSessionEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeSpanDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chbxStartStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource applicationsDataSetBindingSource2;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private System.Windows.Forms.BindingSource activeApplicationsBindingSource1;
        private System.Windows.Forms.BindingSource inactiveApplicationsBindingSource;
        private applicationsDataSet applicationsDataSet;
        private System.Windows.Forms.BindingSource applicationsBindingSource1;
        private System.Windows.Forms.BindingSource inactiveApplicationsBindingSource1;
        private applicationsDataSetTableAdapters.InactiveApplicationsTableAdapter inactiveApplicationsTableAdapter;
        private System.Windows.Forms.BindingSource activeApplicationsBindingSource;
        private applicationsDataSetTableAdapters.ActiveApplicationsTableAdapter activeApplicationsTableAdapter;
    }
}

