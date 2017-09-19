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
        private bool isWorking;

        public string Department
        {
            get { return this.department; }
        }
        public bool IsSweeping
        {
            get { return this.isWorking; }
        }

        public Janitor(string employeeName, int employeeNumber, string department, bool isWorking)
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
            if (isWorking == false)
            {
                Console.WriteLine(employeeName + " is not sweeping now");
            }
            else
            {
                Console.WriteLine(employeeName + " is sweeping now");
            }
        }
    }
}
