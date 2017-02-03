namespace EmployeeRecordManagement
{
    partial class PayrollForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.designationTxt = new System.Windows.Forms.TextBox();
            this.designationLabel = new System.Windows.Forms.Label();
            this.departmentTxt = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.hourlyWageTxt = new System.Windows.Forms.TextBox();
            this.hourlyWageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoursWorkedTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Size = new System.Drawing.Size(465, 96);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(248, 460);
            // 
            // windowTitle
            // 
            this.windowTitle.Size = new System.Drawing.Size(465, 96);
            this.windowTitle.Text = "Payroll Form";
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(511, 413);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(77, 34);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // IDTxt
            // 
            this.IDTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.IDTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.IDTxt.BackColor = System.Drawing.SystemColors.Window;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IDTxt.Location = new System.Drawing.Point(377, 114);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.ReadOnly = true;
            this.IDTxt.Size = new System.Drawing.Size(317, 29);
            this.IDTxt.TabIndex = 12;
            this.IDTxt.TabStop = false;
            // 
            // IDLabel
            // 
            this.IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.IDLabel.Location = new System.Drawing.Point(278, 113);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(99, 31);
            this.IDLabel.TabIndex = 13;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            this.nameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.nameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTxt.Location = new System.Drawing.Point(376, 149);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.ReadOnly = true;
            this.nameTxt.Size = new System.Drawing.Size(318, 29);
            this.nameTxt.TabIndex = 14;
            this.nameTxt.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.nameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(278, 148);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 31);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // designationTxt
            // 
            this.designationTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.designationTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.designationTxt.BackColor = System.Drawing.SystemColors.Window;
            this.designationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.designationTxt.Location = new System.Drawing.Point(376, 184);
            this.designationTxt.Name = "designationTxt";
            this.designationTxt.ReadOnly = true;
            this.designationTxt.Size = new System.Drawing.Size(317, 29);
            this.designationTxt.TabIndex = 17;
            this.designationTxt.TabStop = false;
            // 
            // designationLabel
            // 
            this.designationLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.designationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.designationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.designationLabel.Location = new System.Drawing.Point(278, 183);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(99, 31);
            this.designationLabel.TabIndex = 16;
            this.designationLabel.Text = "Designation";
            this.designationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentTxt
            // 
            this.departmentTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmentTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.departmentTxt.BackColor = System.Drawing.SystemColors.Window;
            this.departmentTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.departmentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.departmentTxt.Location = new System.Drawing.Point(377, 218);
            this.departmentTxt.Name = "departmentTxt";
            this.departmentTxt.ReadOnly = true;
            this.departmentTxt.Size = new System.Drawing.Size(317, 29);
            this.departmentTxt.TabIndex = 18;
            this.departmentTxt.TabStop = false;
            // 
            // departmentLabel
            // 
            this.departmentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.departmentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.departmentLabel.Location = new System.Drawing.Point(278, 218);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(99, 31);
            this.departmentLabel.TabIndex = 19;
            this.departmentLabel.Text = "Department";
            this.departmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hourlyWageTxt
            // 
            this.hourlyWageTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.hourlyWageTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.hourlyWageTxt.BackColor = System.Drawing.SystemColors.Window;
            this.hourlyWageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hourlyWageTxt.Location = new System.Drawing.Point(587, 276);
            this.hourlyWageTxt.Name = "hourlyWageTxt";
            this.hourlyWageTxt.ReadOnly = true;
            this.hourlyWageTxt.Size = new System.Drawing.Size(106, 29);
            this.hourlyWageTxt.TabIndex = 21;
            this.hourlyWageTxt.TabStop = false;
            // 
            // hourlyWageLabel
            // 
            this.hourlyWageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.hourlyWageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hourlyWageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hourlyWageLabel.Location = new System.Drawing.Point(475, 275);
            this.hourlyWageLabel.Name = "hourlyWageLabel";
            this.hourlyWageLabel.Size = new System.Drawing.Size(112, 31);
            this.hourlyWageLabel.TabIndex = 20;
            this.hourlyWageLabel.Text = "Hourly Wage";
            this.hourlyWageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(475, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hours Worked";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hoursWorkedTxt
            // 
            this.hoursWorkedTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.hoursWorkedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.hoursWorkedTxt.Location = new System.Drawing.Point(587, 311);
            this.hoursWorkedTxt.Name = "hoursWorkedTxt";
            this.hoursWorkedTxt.Size = new System.Drawing.Size(106, 29);
            this.hoursWorkedTxt.TabIndex = 0;
            this.hoursWorkedTxt.TextChanged += new System.EventHandler(this.hoursWorkedTxt_TextChanged);
            this.hoursWorkedTxt.Enter += new System.EventHandler(this.hoursWorkedTxt_Enter);
            this.hoursWorkedTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hoursWorkedTxt_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(475, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Earning";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTxt
            // 
            this.totalTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.totalTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.totalTxt.BackColor = System.Drawing.SystemColors.Window;
            this.totalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.totalTxt.Location = new System.Drawing.Point(588, 346);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.ReadOnly = true;
            this.totalTxt.Size = new System.Drawing.Size(106, 29);
            this.totalTxt.TabIndex = 21;
            this.totalTxt.TabStop = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(616, 413);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 34);
            this.cancelBtn.TabIndex = 22;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(714, 459);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hoursWorkedTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourlyWageTxt);
            this.Controls.Add(this.hourlyWageLabel);
            this.Controls.Add(this.departmentTxt);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.designationTxt);
            this.Controls.Add(this.designationLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.saveBtn);
            this.Name = "PayrollForm";
            this.Text = "Employee Records Management - Payroll Form";
            this.Controls.SetChildIndex(this.saveBtn, 0);
            this.Controls.SetChildIndex(this.leftPanel, 0);
            this.Controls.SetChildIndex(this.topPanel, 0);
            this.Controls.SetChildIndex(this.IDLabel, 0);
            this.Controls.SetChildIndex(this.IDTxt, 0);
            this.Controls.SetChildIndex(this.nameLabel, 0);
            this.Controls.SetChildIndex(this.nameTxt, 0);
            this.Controls.SetChildIndex(this.designationLabel, 0);
            this.Controls.SetChildIndex(this.designationTxt, 0);
            this.Controls.SetChildIndex(this.departmentLabel, 0);
            this.Controls.SetChildIndex(this.departmentTxt, 0);
            this.Controls.SetChildIndex(this.hourlyWageLabel, 0);
            this.Controls.SetChildIndex(this.hourlyWageTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.hoursWorkedTxt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.totalTxt, 0);
            this.Controls.SetChildIndex(this.cancelBtn, 0);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox designationTxt;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.TextBox departmentTxt;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox hourlyWageTxt;
        private System.Windows.Forms.Label hourlyWageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hoursWorkedTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
