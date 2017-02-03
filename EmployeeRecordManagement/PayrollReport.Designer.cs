namespace EmployeeRecordManagement
{
    partial class PayrollReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.editBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.navPanel4 = new System.Windows.Forms.Panel();
            this.sortTotalDesc = new System.Windows.Forms.Button();
            this.navPanel3 = new System.Windows.Forms.Panel();
            this.sortTotalAsc = new System.Windows.Forms.Button();
            this.navPanel2 = new System.Windows.Forms.Panel();
            this.sortNameDesc = new System.Windows.Forms.Button();
            this.navPanel1 = new System.Windows.Forms.Panel();
            this.sortNameAsc = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.navPanel4.SuspendLayout();
            this.navPanel3.SuspendLayout();
            this.navPanel2.SuspendLayout();
            this.navPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // windowTitle
            // 
            this.windowTitle.Text = "Weekly Payroll Report";
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AllowUserToDeleteRows = false;
            this.reportTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.reportTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.reportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.reportTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(182)))), ((int)(((byte)(172)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.reportTable.EnableHeadersVisualStyles = false;
            this.reportTable.Location = new System.Drawing.Point(246, 95);
            this.reportTable.MultiSelect = false;
            this.reportTable.Name = "reportTable";
            this.reportTable.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.reportTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.reportTable.RowTemplate.Height = 50;
            this.reportTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.reportTable.Size = new System.Drawing.Size(904, 378);
            this.reportTable.TabIndex = 4;
            this.reportTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportTable_CellDoubleClick);
            this.reportTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.reportTable_DataBindingComplete);
            this.reportTable.SelectionChanged += new System.EventHandler(this.reportTable_SelectionChanged);
            // 
            // editBtn
            // 
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(1022, 486);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(77, 34);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NavigationPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 437);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sort Report:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.NavigationPanel.Controls.Add(this.navPanel4);
            this.NavigationPanel.Controls.Add(this.navPanel3);
            this.NavigationPanel.Controls.Add(this.navPanel2);
            this.NavigationPanel.Controls.Add(this.navPanel1);
            this.NavigationPanel.Location = new System.Drawing.Point(1, 73);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(247, 361);
            this.NavigationPanel.TabIndex = 6;
            // 
            // navPanel4
            // 
            this.navPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.navPanel4.Controls.Add(this.sortTotalDesc);
            this.navPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel4.Location = new System.Drawing.Point(0, 174);
            this.navPanel4.Name = "navPanel4";
            this.navPanel4.Size = new System.Drawing.Size(247, 70);
            this.navPanel4.TabIndex = 3;
            // 
            // sortTotalDesc
            // 
            this.sortTotalDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.sortTotalDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortTotalDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTotalDesc.FlatAppearance.BorderSize = 0;
            this.sortTotalDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTotalDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.sortTotalDesc.Location = new System.Drawing.Point(0, 0);
            this.sortTotalDesc.Name = "sortTotalDesc";
            this.sortTotalDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortTotalDesc.Size = new System.Drawing.Size(247, 70);
            this.sortTotalDesc.TabIndex = 0;
            this.sortTotalDesc.Text = "Total Wage - Descending";
            this.sortTotalDesc.UseVisualStyleBackColor = false;
            this.sortTotalDesc.Click += new System.EventHandler(this.sortTotalDesc_Click);
            // 
            // navPanel3
            // 
            this.navPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.navPanel3.Controls.Add(this.sortTotalAsc);
            this.navPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel3.Location = new System.Drawing.Point(0, 116);
            this.navPanel3.Name = "navPanel3";
            this.navPanel3.Size = new System.Drawing.Size(247, 58);
            this.navPanel3.TabIndex = 2;
            // 
            // sortTotalAsc
            // 
            this.sortTotalAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortTotalAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortTotalAsc.FlatAppearance.BorderSize = 0;
            this.sortTotalAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortTotalAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortTotalAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.sortTotalAsc.Location = new System.Drawing.Point(0, 0);
            this.sortTotalAsc.Name = "sortTotalAsc";
            this.sortTotalAsc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortTotalAsc.Size = new System.Drawing.Size(247, 58);
            this.sortTotalAsc.TabIndex = 1;
            this.sortTotalAsc.Text = "Total Wage - Ascending";
            this.sortTotalAsc.Click += new System.EventHandler(this.sortTotalAsc_Click);
            // 
            // navPanel2
            // 
            this.navPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(236)))));
            this.navPanel2.Controls.Add(this.sortNameDesc);
            this.navPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel2.Location = new System.Drawing.Point(0, 58);
            this.navPanel2.Name = "navPanel2";
            this.navPanel2.Size = new System.Drawing.Size(247, 58);
            this.navPanel2.TabIndex = 1;
            // 
            // sortNameDesc
            // 
            this.sortNameDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.sortNameDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortNameDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortNameDesc.FlatAppearance.BorderSize = 0;
            this.sortNameDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortNameDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.sortNameDesc.Location = new System.Drawing.Point(0, 0);
            this.sortNameDesc.Name = "sortNameDesc";
            this.sortNameDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortNameDesc.Size = new System.Drawing.Size(247, 58);
            this.sortNameDesc.TabIndex = 0;
            this.sortNameDesc.Text = "Name - Descending";
            this.sortNameDesc.UseVisualStyleBackColor = false;
            this.sortNameDesc.Click += new System.EventHandler(this.sortNameDesc_Click);
            // 
            // navPanel1
            // 
            this.navPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(186)))));
            this.navPanel1.Controls.Add(this.sortNameAsc);
            this.navPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel1.Location = new System.Drawing.Point(0, 0);
            this.navPanel1.Name = "navPanel1";
            this.navPanel1.Size = new System.Drawing.Size(247, 58);
            this.navPanel1.TabIndex = 0;
            // 
            // sortNameAsc
            // 
            this.sortNameAsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortNameAsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortNameAsc.FlatAppearance.BorderSize = 0;
            this.sortNameAsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortNameAsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(64)))));
            this.sortNameAsc.Location = new System.Drawing.Point(0, 0);
            this.sortNameAsc.Name = "sortNameAsc";
            this.sortNameAsc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sortNameAsc.Size = new System.Drawing.Size(247, 58);
            this.sortNameAsc.TabIndex = 0;
            this.sortNameAsc.Text = "Name - Ascending";
            this.sortNameAsc.Click += new System.EventHandler(this.sortNameAsc_Click);
            // 
            // PayrollReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1150, 529);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.reportTable);
            this.Name = "PayrollReport";
            this.Text = "Employee Records Management - Payroll Report";
            this.Controls.SetChildIndex(this.reportTable, 0);
            this.Controls.SetChildIndex(this.editBtn, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.topPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.navPanel4.ResumeLayout(false);
            this.navPanel3.ResumeLayout(false);
            this.navPanel2.ResumeLayout(false);
            this.navPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Panel navPanel4;
        private System.Windows.Forms.Button sortTotalDesc;
        private System.Windows.Forms.Panel navPanel3;
        private System.Windows.Forms.Button sortTotalAsc;
        private System.Windows.Forms.Panel navPanel2;
        private System.Windows.Forms.Button sortNameDesc;
        private System.Windows.Forms.Panel navPanel1;
        private System.Windows.Forms.Button sortNameAsc;
    }
}
