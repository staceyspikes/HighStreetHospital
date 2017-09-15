using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Receptionist : EmployeeBase 
    {
        private string department;
        private bool isOnPhone;

        public string Departent
        {
            get { return this.department; }
        }
        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool isOnPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isOnPhone = isOnPhone;

        }
        
    }
}
