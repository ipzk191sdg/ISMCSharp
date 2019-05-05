using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string BirthDate;
        public Person()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            BirthDate = "01.01.1920";
        }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            BirthDate = "01.01.1920";
        }
        public Person(string FirstName, string LastName, string BirthDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
        }
        public Person(Person obj)
        {
            FirstName = obj.FirstName;
            LastName = obj.LastName;
            BirthDate = obj.BirthDate;
        }
        public void SetFirstName(string FirstName)
        {
            if (FirstName.Length > 2)
            {
                this.FirstName = FirstName;
            }
        }
        public void SetLastName(string LastName)
        {
            if (LastName.Length > 2)
            {
                this.LastName = LastName;
            }
        }
        public void SetBirthDate(string BirthDate)
        {
            if (BirthDate.Length == 10)
            {
                this.BirthDate = BirthDate;
            }
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetBirthDate()
        {
            return BirthDate;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Iнформацiя про особу:\n" +
                $"Iм'я: {FirstName};\n" +
                $"Прiзвище: {LastName};\n" +
                $"Дата народження: {BirthDate};\n");
        }
    }
}
