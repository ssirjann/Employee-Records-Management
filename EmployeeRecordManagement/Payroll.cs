using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Blueprint for an employee's payroll detail.
    /// </summary>
    class Payroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public int HourlyWage { get; set; }
        private int hoursWorked;
        public int HoursWorked 
        {
            get
            {
                return this.hoursWorked;
            }
            set
            {
                this.hoursWorked = value;
                this.Total = this.HourlyWage * value;
            }
        }

        public int Total { get; set; }
        public Employee Employee { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payroll"/> class.
        /// </summary>
        /// <param name="emp">The employee.</param>
        /// <param name="hoursWorked">The hours worked.</param>
        public Payroll(Employee emp, int hoursWorked) : this(emp)
        {
            this.HoursWorked = hoursWorked;
            this.Total = this.HoursWorked * this.HourlyWage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Payroll"/> class.
        /// </summary>
        /// <param name="emp">The emp.</param>
        public Payroll (Employee emp)
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Designation = emp.Designation;
            this.Department = emp.Dept;
            this.HourlyWage = emp.HourlyWage;
            this.Employee = emp;
        }

    }
}
