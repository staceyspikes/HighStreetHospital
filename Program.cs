using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStreetHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Michael", 234, "Heart");
            Surgeon surgeon1 = new Surgeon("Vincent", 645, "Brain", true);
            Nurse nurse1 = new Nurse("Sonny", 789, 6);
            Administrator admin1 = new Administrator("Luca", 375, "Business");
            Receptionist recept1 = new Receptionist("Tom", 951, "Office", true);
            Janitor janitor1 = new Janitor("Anthony", 123, "Maintenence", false);

            doctor1.displayInformation();
            surgeon1.displayInformation();
            nurse1.displayInformation();
            admin1.displayInformation();
            recept1.displayInformation();
            janitor1.displayInformation();
            Console.WriteLine();
            surgeon1.displayWorking();
            recept1.displayWorking();
            janitor1.displayWorking();

        }
    }
}
