using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Reads the csv file and makes a list of employee
    /// </summary>
    class CSV
    {
        String fileName;
        List<Employee> empList;
        /// <summary>
        /// The payroll list, initialized as 0 hours to set value for payrollLit in Globals.
        /// </summary>
        List<Payroll> payrollList;
        TextFieldParser parser;
        String delimiter;

        /// <summary>
        /// Initializes a new instance of the <see cref="CSV" /> class.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public CSV(String fileName)
        {
            this.delimiter = ",";
            this.fileName = fileName;
            empList = new List<Employee>();
            payrollList = new List<Payroll>();
        }


        /// <summary>
        /// Gets the list of employees from CSV file
        /// Returns it to caller
        /// </summary>
        /// <returns>List of employees</returns>
        /// <exception cref="Exception"></exception>
        public List<Employee> ParsedEmployeeList()
        {
            try
            {
                parser = new TextFieldParser(fileName);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(this.delimiter);

            while (!parser.EndOfData)
            {
                String[] fields = parser.ReadFields();
                if (string.Compare(fields[1], "name", StringComparison.OrdinalIgnoreCase) == 0)
                    continue;

                Employee emp = InstantiateEmployee(fields);
                this.empList.Add(emp);
            }
            return this.empList;  
        }

        /// <summary>
        /// Instantiates the employee using employee builer
        /// </summary>
        /// <param name="fields">The fields.</param>
        /// <returns></returns>
        private Employee InstantiateEmployee(String [] fields)
        {
            int id = Convert.ToInt32(fields[0]);
            string name = fields[1],
                            address = fields[2],
                            phone = fields[3],
                            email = fields[4],
                            designation = fields[5],
                            department = fields[6];
            int hourlyWage = Convert.ToInt32(fields[7]);

            Employee emp = new Employee.EmployeeBuilder().SetId(id).SetName(name).SetAddress(address).SetPhone(phone).SetEmail(email).SetDepartment(department).SetDesignation(designation).SetHourlyWage(hourlyWage).build();
            return emp;
        }
    }
}
