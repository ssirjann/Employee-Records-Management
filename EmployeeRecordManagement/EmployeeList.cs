using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Starting form of the application
    /// Provides a list of all employees
    /// Provides navigation for using other functions of the system
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EmployeeList : Form
    {
        private string dataFile;
        BindingList<Employee> empList;//Uses binding list so that data bound controls are updated when list updates.
        int row;


        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeList"/> class.
        /// If it is initialized without path for csv file, the root folder of application is checked in.
        /// </summary>
        public EmployeeList () : this("../../../../EmployeeList.csv") { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeList"/> class.
        /// This is called where there is path provided for csv file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public EmployeeList(string fileName)
        {
            this.empList = new BindingList<Employee>();
            this.dataFile = fileName;
            InitializeComponent();
            ImportData();
            row = 0;
            this.employeesTable.DataSource = this.empList;
            ManageGlobalList();
        }

        /// <summary>
        /// Manages the global list of employees.
        /// Calls the handler method on list change.
        /// </summary>
        private void ManageGlobalList()
        {
            Globals.empList = this.empList.ToList();
            this.empList.ListChanged += empList_ListChanged;
        }

        /// <summary>
        /// Handles the ListChanged event of the empList control.
        /// When this.emplist changes, the global list is also updated.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void empList_ListChanged(object sender, EventArgs e)
        {
            Globals.empList = this.empList.ToList();
        }


        /// <summary>
        /// returns true if employee id already exists
        /// returns false if it doesn't
        /// </summary>
        /// <param name="checkingEmp">The checking emp.</param>
        /// <returns>bool</returns>
        private bool EmployeeIdExists(Employee checkingEmp)
        {
            foreach (Employee emp in this.empList)
            {
                if (emp.Id == checkingEmp.Id)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Imports the data from csv filename set in this.filename.
        /// Handles indexoutofrange and format exceptions and shows appropriate error message.
        /// </summary>
        private void ImportData()
        {
            String fileName = this.dataFile;

            try
            {
                CSV csv = new CSV(fileName);
                List <Employee> employees = csv.ParsedEmployeeList();
                foreach (Employee employee in employees)
	            {
                    AddRecord(employee);
	            }
            }
            catch (Exception e)
            {
                if (e is IndexOutOfRangeException || e is FormatException)
                {
                    MessageBox.Show("Please ensure that you select a CSV file and it has values in proper format",
                        "CSV Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateCSVSourceFromUser();
                    return;
                }
                else if (e.Message.IndexOf("Could not find") > -1)
                {
                    MessageBox.Show("The file EmployeeList.csv was not found in the root folder. Please import it manually",
                        "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        /// <summary>
        /// Updates the CSV source from user.
        /// By showing a file selection dialog.
        /// </summary>
        private void UpdateCSVSourceFromUser()
        {
            
            OpenFileDialog fileOpener = new OpenFileDialog();
            fileOpener.ShowDialog();
            if (fileOpener.FileName.Length > 1)
            {
                this.dataFile = fileOpener.FileName;
                ImportData();
            }
        }

        /// <summary>
        /// Adds the record to the list of employee.
        /// </summary>
        /// <param name="emp">The emp.</param>
        private void AddRecord(Employee emp)
        {
            if (EmployeeIdExists(emp))
            {
                MessageBox.Show("Employee id " + emp.Id + " already exists. Skiping record addidition");
                return;
            }
            empList.Add(
                new Employee.EmployeeBuilder()
                .SetId(emp.Id)
                .SetName(emp.Name)
                .SetAddress(emp.Address)
                .SetPhone(emp.Phone)
                .SetEmail(emp.Email)
                .SetDepartment(emp.Dept)
                .SetDesignation(emp.Designation)
                .SetHourlyWage(emp.HourlyWage)
                .build()
            );
                
        }

        /// <summary>
        /// Adds the record to the list of employee
        /// This method gets passed to the delegate in EmployeeForm to handle adding in empList.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EmployeeSavedEventArgs"/> instance containing the event data.</param>
        private void AddRecord(object sender, EmployeeSavedEventArgs e)
        {
            AddRecord(e.Employee);
        }

        /// <summary>
        /// Updates the record of employee.
        /// New instance is created as updating only the properties did not result in proper update in the datagridview
        /// </summary>
        /// <param name="emp">The emp.</param>
        private void UpdateRecord(Employee emp)
        {
            if (EmployeeIdExists(emp) && this.empList[row].Id != emp.Id)
            {
                MessageBox.Show("Employee id " + emp.Id + " already exists. Ignoring record update");
                return;
            }
            empList[row] =
               new Employee.EmployeeBuilder()
               .SetId(emp.Id).SetName(emp.Name)
               .SetAddress(emp.Address)
               .SetPhone(emp.Phone)
               .SetEmail(emp.Email)
               .SetDepartment(emp.Dept)
               .SetDesignation(emp.Designation)
               .SetHourlyWage(emp.HourlyWage)
               .build();
        }

        /// <summary>
        /// Updates the record
        /// This method gets passed to the delegate in EmployeeForm 
        ///     to handle updating in empList form EmployeeForm
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EmployeeSavedEventArgs"/> instance containing the event data.</param>
        private void UpdateRecord(object sender, EmployeeSavedEventArgs e)
        {
            UpdateRecord(e.employee);
        }

        /// <summary>
        /// Handles the Click event of the deleteBtn control.
        /// If deletable, confirms and deletes the record.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (NoEmployeeData()) return;
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you delete this.", "Confirm Delete?", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    this.employeesTable.Rows.RemoveAt(row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Delete failed. Please ensure a row is selected before deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        /// <summary>
        /// Handles the Click event of the addBtn control.
        /// Shows form to add the employee passing AddRecord method.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm empForm = new EmployeeForm();
            empForm.EmployeeSaved += AddRecord;
            empForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the viewChart control.
        /// Shows the salary distribution chart if possible
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void viewChart_Click(object sender, EventArgs e)
        {
            if (NoEmployeeData())
            {
                return;
            }

            Chart earningChart = new Chart();
            earningChart.ShowDialog();
        }

        /// <summary>
        /// Checks if there is no employee in the list.
        /// </summary>
        /// <returns>bool</returns>
        private bool NoEmployeeData()
        {
            if (empList.Count <= 0)
            {
                MessageBox.Show("No employee data found for operation", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Handles the Click event of the import control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void import_Click(object sender, EventArgs e)
        {
            UpdateCSVSourceFromUser();
        }

        /// <summary>
        /// Prepares the employee form by passing instance of an eployee for update
        /// </summary>
        /// <returns>EmployeeForm</returns>
        private EmployeeForm PrepareEmployeeForm()
        {
            int id = this.empList[row].Id;
            string name = this.empList[row].Name;
            string address = this.empList[row].Address;
            string phone = this.empList[row].Phone;
            string email = this.empList[row].Email;
            string designation = this.empList[row].Designation;
            string department = this.empList[row].Dept;
            int hourlyWage = this.empList[row].HourlyWage;

            Employee emp = new Employee.EmployeeBuilder().SetId(id).SetName(name).SetAddress(address).SetPhone(phone).SetEmail(email).SetDepartment(department).SetDesignation(designation).SetHourlyWage(hourlyWage).build();

            EmployeeForm empForm = new EmployeeForm(emp);
            empForm.EmployeeSaved += UpdateRecord;
            return empForm;
        }

        /// <summary>
        /// Handles the Click event of the editBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (NoEmployeeData())
            {
                return;
            }

            EmployeeForm empForm = PrepareEmployeeForm();
            empForm.ShowDialog();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the employeesTable control.
        /// Prompts for edit.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void employeesTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NoEmployeeData())
            {
                return;
            }

            EmployeeForm empForm = PrepareEmployeeForm();
            switch (e.ColumnIndex)
            {
                case 0:
                    empForm.ActiveControl = empForm.Controls["idTxt"];
                    break;
                case 1:
                    empForm.ActiveControl = empForm.Controls["nameTxt"];
                    break;
                case 2:
                    empForm.ActiveControl = empForm.Controls["addressTxt"];
                    break;
                case 3:
                    empForm.ActiveControl = empForm.Controls["phoneTxt"];
                    break;
                case 4:
                    empForm.ActiveControl = empForm.Controls["emailTxt"];
                    break;
                case 5:
                    empForm.ActiveControl = empForm.Controls["designationTxt"];
                    break;
                case 6:
                    empForm.ActiveControl = empForm.Controls["departmentCBox"];
                    break;
                case 7:
                    empForm.ActiveControl = empForm.Controls["hourlyWageTxt"];
                    break;
            }
            empForm.ShowDialog();
        }



        /// <summary>
        /// Handles the Click event of the calcPayroll control.
        /// Hours worked details is asked for each employee whose hours are not already entered.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void calcPayroll_Click(object sender, EventArgs e)
        {
            if (NoEmployeeData())
            {
                return;
            }

            Globals.ReducePayrollList();
            MessageBox.Show("Please input the no. of hours the employees worked in this week.\n\tPress cancel for the employee has not worked", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int count=0;
            for (int i = 0; i < Globals.payrollList.Count; i++) 
            {
                Payroll payroll = Globals.payrollList[i];
                if(payroll.HoursWorked == 0)
                {
                    count++;
                    PayrollForm payrollForm = new PayrollForm(payroll);
                    payrollForm.PayrollUpdated += Globals.UpdateGlobalPayroll;
                    payrollForm.ShowDialog();
                }
            }
            if (count == 0)
            {
                MessageBox.Show("All Payrolls Already Set. To Edit: Click on " + this.viewReport.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            new PayrollReport(this.empList.ToList()).ShowDialog();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the employeesTable control.
        /// updates this.row on selection changed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void employeesTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.row = this.employeesTable.SelectedRows[0].Index;
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        /// <summary>
        /// Handles the Click event of the viewReport control.
        /// Shows the weekly payroll report
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void viewReport_Click(object sender, EventArgs e)
        {
            if (NoEmployeeData())
            {
                return;
            }

            PayrollReport report = new PayrollReport(this.empList.ToList());
            report.ShowDialog();
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the employeesTable control.
        /// On complete, the column width are set to proper sizes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
        private void employeesTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.employeesTable.Columns["id"].Width = 30;
            this.employeesTable.Columns["email"].Width = 200;
            this.employeesTable.Columns["phone"].Width = 100;
            this.employeesTable.Columns["hourlyWage"].HeaderText = "Hourly Wage";
            this.employeesTable.Columns["hourlyWage"].Width = 65;
            //this.employeesTable.Columns["designation"].Width += 30;
        }


  

        

      
    }
}
