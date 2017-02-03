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
    /// This class is a form that creates chart from hours worked detail
    /// </summary>
    /// <seealso cref="EmployeeRecordManagement.BaseForm" />
    partial class Chart : EmployeeRecordManagement.BaseForm
    {
        List<Payroll> payrollList = new List<Payroll>();
        List<ChartItem> chartItemList = new List<ChartItem>();
        int chartTotal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="payrollList">The list of payrolls to create a chart from</param>
        public Chart(List<Payroll> payrollList)
        {
            InitializeComponent();
            this.payrollList = payrollList;
            this.chartTotal = 0;
            PopulateChartItems();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// If no payrollList is provided it used the value from payrollList in Globals.
        /// </summary>
        public Chart()
            : this(Globals.payrollList)
        {
        }

        /// <summary>
        /// Populates the chartItemsList which is later used to draw the chart.
        /// Checks for each payroll's department and adds the total wage to its respective department
        /// </summary>
        private void PopulateChartItems()
        {
            foreach (string department in Globals.departments)
            {
                ChartItem chartItem = new ChartItem(department, 0);
                foreach (Payroll payroll in this.payrollList)
                {
                    if (String.Compare(payroll.Department, department) == 0)
                    {
                        chartItem.Total += payroll.Total;
                    }
                }
                chartItemList.Add(chartItem);
                this.chartTotal += chartItem.Total;
            }
        }

        /// <summary>
        /// Handles the Load event of the Chart control.
        /// When it has been loaded the values from chartItemLists is drawn in chart by this method
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Chart_Load(object sender, EventArgs e)
        {
            foreach (ChartItem chartItem in this.chartItemList)
            {
                if (chartItem.Total > 0)
                    this.payrollChart.Series[0].Points.AddXY(chartItem.Department, chartItem.Total);
            }
        }

        /// <summary>
        /// @override
        /// Shows the form only if there is hours worked entered for atleast 1 employee
        /// 
        /// </summary>
        new public void ShowDialog()
        {
            if (chartTotal != 0)
            {
                base.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input weekly hour detail before creating a chart", "No Data Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        /// <summary>
        /// Handles the Click event of the closeBtn control.
        /// Closes the form
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
