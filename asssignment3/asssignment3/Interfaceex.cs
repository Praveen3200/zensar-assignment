using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
        interface Istudent
        {

            void ShowDetails(string Name, int Id);
        }
        class Dayscholar : Istudent
        {


            public void ShowDetails(string Name, int id)
            {
                Console.WriteLine("DayScholars Name: " + Name);
                Console.WriteLine("DayScholars ID: " + id);

            }
        }
        class Resident : Istudent
        {

            //Accessing Interface Values for properties instead of declaration

            public void ShowDetails(string Name, int ID)
            {

                Console.WriteLine("Name of the Resident Student: " + Name);
                Console.WriteLine("Resident Student ID: " + ID);

            }

        }
        class InterfaceExample
        {
            static void Main()
            {
                Istudent stud = new Dayscholar();
                Console.WriteLine("Dayscholar Details:");
                stud.ShowDetails("praveen", 24);
                Istudent student = new Resident();
                Console.WriteLine("Resident Details:");
                student.ShowDetails("zensar", 4);
                Console.ReadLine();
            }
        }
}
