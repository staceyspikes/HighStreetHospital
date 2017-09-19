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
        private bool isWorking;

        public string Departent
        {
            get { return this.department; }
        }
        public bool IsWorking
        {
            get { return this.isWorking; }
        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isWorking = isWorking;

        }
        public override void displayInformation()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(department + "\t");
            Console.Write(isWorking + "\n");
        }
        public override void displayWorking()
        {
            if(isWorking == true)
            {
                Console.WriteLine(employeeName + " is on the phone right now");
            }
            else
            {
                Console.WriteLine(employeeName + " is not on the phone right now");
            }
        }

        
    }
}
