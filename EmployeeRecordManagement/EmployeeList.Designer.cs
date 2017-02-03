namespace EmployeeRecordManagement
{
    partial class EmployeeList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.windowTitle = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeesTable = new System.Windows.Forms.DataGridView();
            this.splitBody = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.navPanel4 = new System.Windows.Forms.Panel();
            this.viewChart = new System.Windows.Forms.Button();
            this.navPanel3 = new System.Windows.Forms.Panel();
            this.viewReport = new System.Windows.Forms.Button();
            this.navPanel2 = new System.Windows.Forms.Panel();
            this.import = new System.Windows.Forms.Button();
            this.navPanel1 = new System.Windows.Forms.Panel();
            this.calcPayroll = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.headContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).BeginInit();
            this.splitBody.Panel1.SuspendLayout();
            this.splitBody.Panel2.SuspendLayout();
            this.splitBody.SuspendLayout();
            this.panel1.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.navPanel4.SuspendLayout();
            this.navPanel3.SuspendLayout();
            this.navPanel2.SuspendLayout();
            this.navPanel1.SuspendLayout();
            this.headContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.splitContainer.Panel1.Controls.Add(this.windowTitle);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.deleteBtn);
            this.splitContainer.Panel2.Controls.Add(this.editBtn);
            this.splitContainer.Panel2.Controls.Add(this.addBtn);
            this.splitContainer.Panel2.Controls.Add(this.employeesTable);
            this.splitContainer.Size = new System.Drawing.Size(905, 529);
            this.splitContainer.SplitterDistance = 85;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // windowTitle
            // 
            this.windowTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowTitle.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.windowTitle.Location = new System.Drawing.Point(0, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(905, 85);
            this.windowTitle.TabIndex = 1;
            this.windowTitle.Text = "Details of All Employees";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(754, 394);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(77, 34);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(646, 394);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(77, 34);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(536, 394);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(77, 34);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeesTable
            // 
            this.employeesTable.AllowUserToAddRows = false;
            this.employeesTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.employeesTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.employeesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.employeesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.employeesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.employeesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.employeesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employeesTable.EnableHeadersVisualStyles = false;
            this.employeesTable.Location = new System.Drawing.Point(0, 0);
            this.employeesTable.MultiSelect = false;
            this.employeesTable.Name = "employeesTable";
            this.employeesTable.ReadOnly = true;
            this.employeesTable.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employeesTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.employeesTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.employeesTable.RowTemplate.Height = 50;
            this.employeesTable.RowTemplate.ReadOnly = true;
            this.employeesTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.employeesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesTable.Size = new System.Drawing.Size(905, 376);
            this.employeesTable.TabIndex = 0;
            this.employeesTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeesTable_CellDoubleClick);
            this.employeesTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.employeesTable_DataBindingComplete);
            this.employeesTable.SelectionChanged += new System.EventHandler(this.employeesTable_SelectionChanged);
            // 
            // splitBody
            // 
            this.splitBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitBody.IsSplitterFixed = true;
            this.splitBody.Location = new System.Drawing.Point(0, 0);
            this.splitBody.Name = "splitBody";
            // 
            // splitBody.Panel1
            // 
            this.splitBody.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.splitBody.Panel1.Controls.Add(this.panel1);
            this.splitBody.Panel1.Controls.Add(this.NavigationPanel);
            // 
            // splitBody.Panel2
            // 
            this.splitBody.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.splitBody.Panel2.Controls.Add(this.splitContainer);
            this.splitBody.Size = new System.Drawing.Size(1150, 529);
            this.splitBody.SplitterDistance = 244;
            this.splitBody.SplitterWidth = 1;
            this.splitBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 91);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Records";
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.NavigationPanel.Controls.Add(this.navPanel4);
            this.NavigationPanel.Controls.Add(this.navPanel3);
            this.NavigationPanel.Controls.Add(this.navPanel2);
            this.NavigationPanel.Controls.Add(this.navPanel1);
            this.NavigationPanel.Location = new System.Drawing.Point(0, 165);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(244, 364);
            this.NavigationPanel.TabIndex = 3;
            // 
            // navPanel4
            // 
            this.navPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.navPanel4.Controls.Add(this.viewChart);
            this.navPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel4.Location = new System.Drawing.Point(0, 174);
            this.navPanel4.Name = "navPanel4";
            this.navPanel4.Size = new System.Drawing.Size(244, 70);
            this.navPanel4.TabIndex = 3;
            // 
            // viewChart
            // 
            this.viewChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.viewChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewChart.FlatAppearance.BorderSize = 0;
            this.viewChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.viewChart.Location = new System.Drawing.Point(0, 0);
            this.viewChart.Name = "viewChart";
            this.viewChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewChart.Size = new System.Drawing.Size(244, 70);
            this.viewChart.TabIndex = 0;
            this.viewChart.Text = "Payroll Chart";
            this.viewChart.UseVisualStyleBackColor = false;
            this.viewChart.Click += new System.EventHandler(this.viewChart_Click);
            // 
            // navPanel3
            // 
            this.navPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.navPanel3.Controls.Add(this.viewReport);
            this.navPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel3.Location = new System.Drawing.Point(0, 116);
            this.navPanel3.Name = "navPanel3";
            this.navPanel3.Size = new System.Drawing.Size(244, 58);
            this.navPanel3.TabIndex = 2;
            // 
            // viewReport
            // 
            this.viewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewReport.FlatAppearance.BorderSize = 0;
            this.viewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.viewReport.Location = new System.Drawing.Point(0, 0);
            this.viewReport.Name = "viewReport";
            this.viewReport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewReport.Size = new System.Drawing.Size(244, 58);
            this.viewReport.TabIndex = 1;
            this.viewReport.Text = "Weekly Report";
            this.viewReport.Click += new System.EventHandler(this.viewReport_Click);
            // 
            // navPanel2
            // 
            this.navPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.navPanel2.Controls.Add(this.import);
            this.navPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel2.Location = new System.Drawing.Point(0, 58);
            this.navPanel2.Name = "navPanel2";
            this.navPanel2.Size = new System.Drawing.Size(244, 58);
            this.navPanel2.TabIndex = 1;
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.import.FlatAppearance.BorderSize = 0;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.import.Location = new System.Drawing.Point(0, 0);
            this.import.Name = "import";
            this.import.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.import.Size = new System.Drawing.Size(244, 58);
            this.import.TabIndex = 0;
            this.import.Text = "Import Employee Data";
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // navPanel1
            // 
            this.navPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.navPanel1.Controls.Add(this.calcPayroll);
            this.navPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel1.Location = new System.Drawing.Point(0, 0);
            this.navPanel1.Name = "navPanel1";
            this.navPanel1.Size = new System.Drawing.Size(244, 58);
            this.navPanel1.TabIndex = 0;
            // 
            // calcPayroll
            // 
            this.calcPayroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calcPayroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calcPayroll.FlatAppearance.BorderSize = 0;
            this.calcPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.calcPayroll.Location = new System.Drawing.Point(0, 0);
            this.calcPayroll.Name = "calcPayroll";
            this.calcPayroll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calcPayroll.Size = new System.Drawing.Size(244, 58);
            this.calcPayroll.TabIndex = 0;
            this.calcPayroll.Text = "Input Week\'s Work Data";
            this.calcPayroll.Click += new System.EventHandler(this.calcPayroll_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(24, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(206, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Employee Records";
            // 
            // headContainer
            // 
            this.headContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.headContainer.Controls.Add(this.title);
            this.headContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headContainer.Location = new System.Drawing.Point(0, 0);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(244, 85);
            this.headContainer.TabIndex = 2;
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1150, 529);
            this.Controls.Add(this.splitBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Records Management - Main Window";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesTable)).EndInit();
            this.splitBody.Panel1.ResumeLayout(false);
            this.splitBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitBody)).EndInit();
            this.splitBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.navPanel4.ResumeLayout(false);
            this.navPanel3.ResumeLayout(false);
            this.navPanel2.ResumeLayout(false);
            this.navPanel1.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.SplitContainer splitBody;
        private System.Windows.Forms.Label windowTitle;
        protected System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel navPanel4;
        private System.Windows.Forms.Button viewChart;
        private System.Windows.Forms.Panel navPanel3;
        private System.Windows.Forms.Button viewReport;
        private System.Windows.Forms.Panel navPanel2;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Panel navPanel1;
        private System.Windows.Forms.Button calcPayroll;
        private System.Windows.Forms.DataGridView employeesTable;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel headContainer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;






    }
}

