using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Shows a report of payroll of each employee whose record in maintained in the application
    /// </summary>
    /// <seealso cref="EmployeeRecordManagement.BaseForm" />
    public partial class PayrollReport : EmployeeRecordManagement.BaseForm
    {
        BindingList<Payroll> payrollList;   //Uses binding list so that data bound controls are updated when list updates.
        List<Employee> empList;
        int row;

        /**
         * Constructor
         * 
         */
        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollReport"/> class.
        /// First, initialzed empty payroll for each employee
        /// Then, from global list, updates payroll details of employees that was previously set.
        /// </summary>
        /// <param name="employeeList">The employee list.</param>
        public PayrollReport(List<Employee> employeeList)
        {
            InitializeComponent();
            this.empList = employeeList;
            this.payrollList = new BindingList<Payroll>();
            GeneratePayrollList();  //ge
            this.reportTable.DataSource = this.payrollList;
            this.row=0;
            HideLastColumn();       //Last record in Payroll is Employee object, so it is hidden
            ManageGlobalList();
        }

        /// <summary>
        /// Hides the last column.
        /// Necessary because the last attribute of Payroll class is of employee instance.
        /// </summary>
        private void HideLastColumn()
        {
            int col = this.reportTable.Columns.Count - 1;
            this.reportTable.Columns[col].Visible = false;
        }
        /// <summary>
        /// Manages the global list.
        /// From global list, removes payroll detail of employee not present in the global employee list
        /// Then set payroll detail of employee in this class from global payroll list if set there.
        /// Calls the handler method on list change.
        /// </summary>
        private void ManageGlobalList()
        {
            if(Globals.payrollList.Count == 0) 
            {
                Globals.payrollList = this.payrollList.ToList(); ;
            }
            else
            {
                for (int i = 0; i < this.payrollList.Count; i++)
                {
                    Payroll localPayroll = this.payrollList[i];
                    foreach (Payroll globalPayroll in Globals.payrollList)
                    {
                        if (localPayroll.Id == globalPayroll.Id)
                        {
                            localPayroll.HoursWorked = globalPayroll.HoursWorked;
                            this.payrollList[i] = localPayroll;
                        }
                    }
                }
                Globals.payrollList = this.payrollList.ToList();
            }
            this.payrollList.ListChanged += payrollList_ListChanged;
        }

        /// <summary>
        /// Handles the ListChanged event of the payrollList control.
        /// When this.payrollList changes, the global list is also updated.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void payrollList_ListChanged(object sender, EventArgs e)
        {
            Globals.payrollList = this.payrollList.ToList();
            this.reportTable.DataSource = this.payrollList;
        }

        /// <summary>
        /// Generates the payroll list by initializing it with only the employee detail
        /// Payroll detail is set as 0;
        /// </summary>
        private void GeneratePayrollList()
        {
            foreach (Employee emp in this.empList)
            {
                this.payrollList.Add(new Payroll(emp, 0));
            }
        }

        /// <summary>
        /// Updates the record of payroll.
        /// New instance is created as updating only the properties did not result in proper update in the datagridview
        /// </summary>
        /// <param name="hoursWorked">The hours worked.</param>
        private void UpdateRecord(int hoursWorked)
        {
            Payroll payroll = this.payrollList[row];
            this.payrollList[row] = new Payroll(payroll.Employee, hoursWorked);
        }

        /// <summary>
        /// Gets passed to the delegate in the PayrollForm.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PayrollUpdatedEventArgs"/> instance containing the event data.</param>
        private void UpdateRecord(object sender, PayrollUpdatedEventArgs e)
        {
            UpdateRecord(e.Payroll.HoursWorked);
        }

        /// <summary>
        /// Handles the SelectionChanged event of the reportTable control.
        /// on the selected row change, the this.row is updated.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void reportTable_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.row = this.reportTable.SelectedCells[0].RowIndex;
                if (this.reportTable.Rows[row].Cells["hoursWorked"].Selected != true)
                {
                    this.reportTable.Rows[row].Cells["hoursWorked"].Selected = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                //no need to do anything in this case
            }
        }

        /// <summary>
        /// Sorts the report by total wage in ascending order using bubble sort.
        /// </summary>
        private void SortByTotalAscending()
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < this.payrollList.Count - 1; i++)
                {
                    if (payrollList[i].Total > payrollList[i + 1].Total)
                    {
                        sorted = false;
                        Payroll tempPayroll = this.payrollList[i];
                        this.payrollList[i] = this.payrollList[i+1];
                        this.payrollList[i+1] = tempPayroll;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the report by total wage in descending order using bubble sort.
        /// </summary>
        private void SortByTotalDescending()
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < this.payrollList.Count - 1; i++)
                {
                    if (payrollList[i].Total < payrollList[i + 1].Total)
                    {
                        sorted = false;
                        Payroll tempPayroll = this.payrollList[i];
                        this.payrollList[i] = this.payrollList[i + 1];
                        this.payrollList[i + 1] = tempPayroll;
                    }
                }
            }
        }

        /// <summary>
        /// Sorts the report by name in ascending order using bubble sort.
        /// </summary>
        private void SortByNameAscending()
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < this.payrollList.Count - 1; i++)
                {
                    if (String.Compare(this.payrollList[i].Name, this.payrollList[i+1].Name) > 0)
                    {
                        sorted = false;
                        Payroll tempPayroll = this.payrollList[i];
                        this.payrollList[i] = this.payrollList[i + 1];
                        this.payrollList[i + 1] = tempPayroll;
                    }
                }
            }
        }


        /// <summary>
        /// Sorts the report by name in ascending order using bubble sort.
        /// </summary>
        private void SortByNameDescending()
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < this.payrollList.Count - 1; i++)
                {
                    if (String.Compare(this.payrollList[i].Name, this.payrollList[i+1].Name) < 0)
                    {
                        sorted = false;
                        Payroll tempPayroll = this.payrollList[i];
                        this.payrollList[i] = this.payrollList[i + 1];
                        this.payrollList[i + 1] = tempPayroll;
                    }
                }
            }
        }

        /// <summary>
        /// Prompts the edit of selected payroll detail.
        /// Called on cell double click and on edit button click
        /// </summary>
        private void PromptEdit()
        {
            PayrollForm payrollForm = new PayrollForm(this.payrollList[row]);
            payrollForm.PayrollUpdated += UpdateRecord;
            payrollForm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the editBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            PromptEdit();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the reportTable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void reportTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PromptEdit();
        }

        /// <summary>
        /// Handles the Click event of the sortNameAsc control.
        /// Sorts name in ascending order of name
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sortNameAsc_Click(object sender, EventArgs e)
        {
            SortByNameAscending();
        }

        /// <summary>
        /// Handles the Click event of the sortNameDesc control.
        /// Sorts name in descending order of name
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sortNameDesc_Click(object sender, EventArgs e)
        {
            SortByNameDescending();
        }

        /// <summary>
        /// Handles the Click event of the sortTotalAsc control.
        /// Sorts name in ascending order of total wage.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sortTotalAsc_Click(object sender, EventArgs e)
        {
            SortByTotalAscending();
        }

        /// <summary>
        /// Handles the Click event of the sortTotalDesc control.
        /// Sorts name in descending order of total wage.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void sortTotalDesc_Click(object sender, EventArgs e)
        {
            SortByTotalDescending();
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the reportTable control.
        /// The width are set to provide better view of data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewBindingCompleteEventArgs"/> instance containing the event data.</param>
        private void reportTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.reportTable.Columns["id"].Width = 30;
            this.reportTable.Columns["hourlyWage"].HeaderText = "Hourly Wage";
            this.reportTable.Columns["hoursWorked"].HeaderText = "Hours Worked";
            this.reportTable.Columns["name"].Width = 200;
        }

    }
}
