using System;
using System.Windows.Forms;


namespace EmployeeRecordManagement
{
    /// <summary>
    /// Form that takes details of the employee for adding or editing
    /// </summary>
    /// <seealso cref="EmployeeRecordManagement.BaseForm" />
    public partial class EmployeeForm : EmployeeRecordManagement.BaseForm
    {
        public Employee employee;

        public delegate void EmployeeAdder(object sender, EmployeeSavedEventArgs e);

        public event EmployeeAdder EmployeeSaved;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeForm"/> class.
        /// If employee instance is received, its data is added to textboxes for edit.
        /// </summary>
        /// <param name="emp">The employee</param>
        public EmployeeForm(Employee emp) : this()
        {
            this.employee = emp;
            LoadData();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeForm"/> class.
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();
            SetComboBox();
        }

        /// <summary>
        /// Sets the ComboBox using department list in Globals.
        /// </summary>
        private void SetComboBox()
        {
            string[] departments = Globals.departments;

            foreach (string department in departments)
            {
                this.departmentCBox.Items.Add(department);
            }
        }


        /// <summary>
        /// Loads the data in this.employee into the forms for edit.
        /// </summary>
        private void LoadData()
        {
            this.IDTxt.Text = Convert.ToString(employee.Id);
            this.HourlyWageTxt.Text = Convert.ToString(employee.HourlyWage);
            this.nameTxt.Text = employee.Name;
            this.addressTxt.Text = employee.Address;
            this.phoneTxt.Text = employee.Phone;
            this.emailTxt.Text = employee.Email;
            this.designationTxt.Text = employee.Designation;
            this.departmentCBox.Text = employee.Dept;
        }
        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// The errors must to cleared to enable form closing.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.errorProvider.Clear();
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the saveBtn control.
        /// Validates the fields and
        /// If valid, uses the delegate to save.
        /// The delegate comes from EmployeeList class.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidFields()) return;

            int id, hourlyWage;
            try
            {
                id = TryParse(this.IDTxt);
                hourlyWage = TryParse(this.HourlyWageTxt);
            }
            catch (OverflowException ex)
            {
                return;
            }
            string name = this.nameTxt.Text;
            string address = this.addressTxt.Text;
            string phone = this.phoneTxt.Text;
            string email = this.emailTxt.Text;
            string designation = this.designationTxt.Text;
            string department = this.departmentCBox.Text;

            this.employee = new Employee.EmployeeBuilder().SetId(id).SetName(name).SetAddress(address).SetPhone(phone).SetEmail(email).SetDepartment(department).SetDesignation(designation).SetHourlyWage(hourlyWage).build();
            EmployeeSavedEventArgs args = new EmployeeSavedEventArgs(this.employee);

            EmployeeSaved(this, args);
            this.Close();
        }

        /// <summary>
        /// Tries the parse of int fields
        /// If failed sets error message in them
        /// </summary>
        /// <param name="tBox">The text box with integer field</param>
        /// <returns></returns>
        /// <exception cref="OverflowException"></exception>
        private int TryParse(TextBox tBox)
        {
            int output = 0;
            try
            {
                output = Convert.ToInt32(tBox.Text);
            }
            catch (Exception ex)
            {
                if (ex is OverflowException)
                {
                    this.errorProvider.SetError(tBox, "Value too large");
                    throw new OverflowException();
                }
            }
            return output;
        }

        /// <summary>
        /// Validates the fields.
        /// Sets error where invalid
        /// </summary>
        /// <returns>true is valid</returns>
        private bool ValidFields()
        {
            bool valid = true;
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(tBox.Text))
                    {
                        this.errorProvider.SetError(tBox, "Field Required");
                        valid = false;
                    }
                    else if (String.Compare(tBox.Name, this.emailTxt.Name) == 0)
                    {
                        string email = this.emailTxt.Text;
                        {
                            if (!(email.IndexOf('@') > 0 && email.IndexOf('.', email.IndexOf('@')) > email.IndexOf('@')+1))
                            {
                                this.errorProvider.SetError(tBox, "Email Invalid");
                                valid = false;
                            }
                        }
                    }
                }
                else if (c is ComboBox)
                {
                    ComboBox cBox = c as ComboBox;
                    if (cBox.SelectedIndex < 0)
                    {
                        this.errorProvider.SetError(cBox, "Field Required");
                    }
                }
            }
            return valid;
        }

        /// <summary>
        /// Handles the KeyDown event of the IntField control.
        /// Allows the key only if it is a number
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void IntField_KeyDown(object sender, KeyEventArgs e)
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
        /// Removes the error from focused field.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RemoveError(object sender, EventArgs e)
        {
            this.errorProvider.SetError((sender as Control), "");
        }

    }

    /// <summary>
    /// Arguments for when the employee detail is saved
    /// </summary>
    /// <seealso cref="System.EventArgs" />
    public class EmployeeSavedEventArgs : EventArgs
    {
        public Employee employee;

        public EmployeeSavedEventArgs(Employee employee)
        {
            this.employee = employee;
        }

        public Employee Employee
        {
            get
            {
                return this.employee;
            }
        }
    }
}
