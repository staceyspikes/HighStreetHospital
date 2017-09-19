using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Surgeon : EmployeeBase 
    {
        private string specialtyArea;
        private bool isWorking;

        public string SpecialtryArea
        {
           get { return this.specialtyArea; }
        }
        public bool IsWorking
        {
            get { return this.isWorking; }
        }
        
        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isWorking )
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isWorking = isWorking;

        }
        public override void displayInformation()
        {
            Console.Write(employeeName + "\t");
            Console.Write(employeeNumber + "\t");
            Console.Write(specialtyArea + "\t");
            Console.Write(isWorking + "\n");
        }
        public override void displayWorking()
        {
            if (isWorking == true)
            {
                Console.WriteLine(employeeName + " is operating now");
            }
            else
            {
                Console.WriteLine(employeeName + " is not operating now");
            }

        }
    }
}
