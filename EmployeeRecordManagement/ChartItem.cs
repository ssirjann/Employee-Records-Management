using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRecordManagement
{
    /// <summary>
    /// Blueprint for each entry into the chart in chart class
    /// </summary>
    public class ChartItem
    {
        public string Department { get; set; }
        public int Total { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartItem"/> class.
        /// </summary>
        /// <param name="department">The department.</param>
        /// <param name="total">The total.</param>
        public ChartItem(string department, int total)
        {
            this.Department = department;
            this.Total = total;
        }
    }
}
