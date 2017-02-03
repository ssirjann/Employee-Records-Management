using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Maintains values required throughout the application
    /// The data are needed until the application is running
    /// </summary>
    static class Globals
    {
        /// <summary>
        /// The employee list
        /// </summary>
        public static List<Employee> empList = new List<Employee>();
        /// <summary>
        /// The payroll list
        /// </summary>
        public static List<Payroll> payrollList = new List<Payroll>();

        /// <summary>
        /// The departments
        /// </summary>
        public static string[] departments = {
                                                "Purchase",
                                                "Production",
                                                "Marketing",
                                                "HRM",
                                                "Finance",
                                                "IT"
                                            };


        /// <summary>
        /// Removes all data from payroll list whose employee are already deleted
        /// </summary>
        public static void ReducePayrollList()
        {
            List<Payroll> localPayrollList = new List<Payroll>();

            if (payrollList.Count == 0)
            {
                foreach (Employee employee in empList)
                {
                    payrollList.Add(new Payroll(employee));
                }
            }

            foreach (Payroll payroll in payrollList)
            {
                foreach (Employee employee in empList)
                {
                    if (payroll.Employee.Id == employee.Id)
                    {
                        localPayrollList.Add(payroll);
                    }
                }
            }
            payrollList = localPayrollList;
        }


        /// <summary>
        /// Updates the global payroll.
        /// passed as delegate to payrollform when it is called from EmployeeList.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="PayrollUpdatedEventArgs"/> instance containing the event data.</param>
        public static void UpdateGlobalPayroll(object sender, PayrollUpdatedEventArgs e)
        {
            for (int i=0; i<payrollList.Count; i++)
            {
                Payroll payroll = payrollList[i];
                if (payroll.Employee.Id == e.Payroll.Employee.Id)
                {
                    payrollList[i] = e.Payroll;
                }
            }
        }
    }
}
