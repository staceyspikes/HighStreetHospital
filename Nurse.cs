using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Nurse : EmployeeBase 
    {
        private int numberOfPatients;

        private int NumberOfPatients
        {
            get { return this.numberOfPatients; }
        }
         public Nurse(string employeeName, int employeeNumber, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.numberOfPatients = numberOfPatients;


        }
        public override void displayInformation()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(numberOfPatients + "\n");
            
        }
    }
}
