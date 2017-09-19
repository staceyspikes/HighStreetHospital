using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Doctor : EmployeeBase 
    {
        private string specialtyArea;

        public string SpecialtyArea
            {
               get { return this.specialtyArea; }
            }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }
        
        public override void displayInformation()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(specialtyArea + "\n");
        }

    }
}
