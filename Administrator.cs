using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Administrator : EmployeeBase 
    {
        private string department;

        public string Department
        {
            get { return this.department; }
        }

        public Administrator(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }
    }
}
