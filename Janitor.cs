using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Janitor : EmployeeBase 
    {
        private string department;
        private bool isSweeping;

        public string Department
        {
            get { return this.department; }
        }
        public bool IsSweeping
        {
            get { return this.isSweeping; }
        }

        public Janitor(string employeeName, int employeeNumber, string department, bool isSweeping)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isSweeping = isSweeping;
        }
    }
}
