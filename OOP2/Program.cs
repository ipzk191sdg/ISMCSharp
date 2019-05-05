using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib2;
namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];
            people[0] = new Person("Tatyana", "Vishnyakova", "04.05.1990");
            people[1] = new Applicant("Ruslan", "Borisenko", "05.04.2002", 210, 10.2, "ZOSH№32");
            people[2] = new Student("Anastasia", "Khovanska", "10.10.2000", 3, "PZ34", "121", "KPI");
            people[3] = new Teacher("Igor", "Savelyev", "25.02.1969", "Math", "NPUIF");
            people[4] = new LibraryUser("Alina", "Sokolova", "06.12.1985", 1556, "12.05.2010", 15.25);
            for (int i = 0; i < people.Length; i++)
                people[i].ShowInfo();
        }
    }
}
