using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Blueprint for employee record
    /// </summary>
    public class Employee
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Address {get;set;}
        public string Phone {get;set;}
        public string Email {get;set;}
        public string Designation {get;set;}
        public string Dept {get;set;}
        public int HourlyWage {get;set;}




        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// It uses a builder pattern as otherwise there would be too many arguments in constructor
        /// </summary>
        /// <param name="builder">The builder of EmployeeBuilder type</param>
        private Employee (EmployeeBuilder builder) 
        {
            this.Id = builder.id;
            this.Name = builder.Name;
            this.Address = builder.Address;
            this.Phone = builder.Phone;
            this.Email = builder.Email;
            this.Designation = builder.Designation;
            this.Dept = builder.Department;
            this.HourlyWage = builder.HourlyWage;
        }

        /// <summary>
        /// EmployeeBuilder for easier instantiation of employee
        /// Each set method returns the current object to enable method chaining
        /// </summary>
        public class EmployeeBuilder
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Designation { get; set; }
            public string Department { get; set; }
            public int HourlyWage { get; set; }

            public EmployeeBuilder SetId(int id)
            {
                this.id = id;
                return this;
            }
            public EmployeeBuilder SetName(string name)
            {
                this.Name = name;
                return this;
            }
            public EmployeeBuilder SetEmail(string email)
            {
                this.Email = email;
                return this;
            }
            public EmployeeBuilder SetAddress(string address)
            {
                this.Address = address;
                return this;
            }
            public EmployeeBuilder SetPhone(string phone)
            {
                this.Phone = phone;
                return this;
            }

            public EmployeeBuilder SetDesignation(string designation)
            {
                this.Designation = designation;
                return this;
            }

            public EmployeeBuilder SetDepartment(string department)
            {
                this.Department = department;
                return this;
            }

            public EmployeeBuilder SetHourlyWage(int hourlyWage)
            {
                this.HourlyWage = hourlyWage;
                return this;
            }

            /// <summary>
            /// Builds employee instance.
            /// </summary>
            /// <returns>employee instance</returns>
            public Employee build()
            {
                return new Employee(this);
            }
        }
    }
}
