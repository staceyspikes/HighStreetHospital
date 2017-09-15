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
        private bool isOperating;

        private string SpecialtryArea
        {
           get { return this.specialtyArea; }
        }
        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating )
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;

        }
    }
}
