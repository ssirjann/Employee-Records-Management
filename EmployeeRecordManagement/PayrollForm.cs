using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Form that takes worked hours of an employee to calculate week's total wage
    /// </summary>
    /// <seealso cref="EmployeeRecordManagement.BaseForm" />
    partial class PayrollForm : EmployeeRecordManagement.BaseForm
    {
        private Payroll payroll;
        public delegate void PayrollUpdateHandler(object sender, PayrollUpdatedEventArgs e);
        public event PayrollUpdateHandler PayrollUpdated;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollForm"/> class.
        /// </summary>
        /// <param name="payroll">The payroll.</param>
        public PayrollForm(Payroll payroll)
        {
            this.payroll = payroll;
            InitializeComponent();
            this.hoursWorkedTxt.MaxLength = 2;
            LoadData();     //All data except worked hours and total wage need to be preloaded for providing necessary information
        }

        /// <summary>
        /// Loads the data - id, name, designation, department, hourlywage and if already set, the worked hours and total wage
        /// </summary>
        private void LoadData()
        {
            this.IDTxt.Text = this.payroll.Id.ToString();
            this.nameTxt.Text = this.payroll.Name;
            this.designationTxt.Text = this.payroll.Designation;
            this.departmentTxt.Text = this.payroll.Department;
            this.hourlyWageTxt.Text = this.payroll.HourlyWage.ToString();
            if (this.payroll.HoursWorked > 0)
                this.hoursWorkedTxt.Text = this.payroll.HoursWorked.ToString();
        }

        /// <summary>
        /// Handles the KeyDown event of the hoursWorkedTxt control.
        /// Accepts the key press only if it is a number
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void hoursWorkedTxt_KeyDown(object sender, KeyEventArgs e)
        {
            char key = (char)e.KeyCode;
            if (!char.IsDigit(key) 
                && e.KeyCode.ToString() != "Back" 
                && e.KeyCode.ToString() != "Delete"
               )
            {
                e.SuppressKeyPress = true;
                return;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the hoursWorkedTxt control.
        /// Validates hours worked.
        /// If the value is capped to 40 for a week's data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void hoursWorkedTxt_TextChanged(object sender, EventArgs e)
        {
            int hrsWorked;

            if (string.IsNullOrWhiteSpace(this.hoursWorkedTxt.Text))
                hrsWorked = 0;
            else 
            {
                hrsWorked = Convert.ToInt32(this.hoursWorkedTxt.Text);
                if (hrsWorked > 40)
                {
                    this.hoursWorkedTxt.Text = "40";
                    hrsWorked = 40;
                }
            }
            int total = hrsWorked * this.payroll.HourlyWage;

            this.totalTxt.Text = total.ToString();
        }

        /// <summary>
        /// Handles the Click event of the saveBtn control.
        /// Saves the input data using delegate.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(!ValidFields()) return;
            this.payroll.HoursWorked = Convert.ToInt32(hoursWorkedTxt.Text);
            PayrollUpdatedEventArgs args = new PayrollUpdatedEventArgs(this.payroll);

            this.PayrollUpdated(this, new PayrollUpdatedEventArgs(this.payroll));
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// Clears the errors to allow form closing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            this.Close();
        }

        /// <summary>
        /// Validates the fields.
        /// Sets error message where invalid
        /// </summary>
        /// <returns></returns>
        private bool ValidFields()
        {
            TextBox hrsWorkedTxt = this.hoursWorkedTxt;
            if (string.IsNullOrWhiteSpace(hrsWorkedTxt.Text))
            {
                this.errorProvider.SetError(this.hoursWorkedTxt, "Required Field");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Handles the Enter event of the hoursWorkedTxt control.
        /// Errors are cleared on focus.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void hoursWorkedTxt_Enter(object sender, EventArgs e)
        {
            this.errorProvider.SetError((sender as TextBox), "");
        }

    }

    /// <summary>
    /// Arguments for when the payroll detail is saved
    /// </summary>
    /// <seealso cref="System.EventArgs" />
     class PayrollUpdatedEventArgs : EventArgs
    {
        public Payroll payroll;

        public PayrollUpdatedEventArgs(Payroll payroll)
        {
            this.payroll = payroll;
        }

        public Payroll Payroll
        {
            get 
            {
                return this.payroll;
            }
        }
    }
}
