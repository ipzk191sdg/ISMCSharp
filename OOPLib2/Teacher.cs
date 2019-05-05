using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Teacher : Person
    {
        protected string Position;
        protected string Chair;
        protected string UniName;
        public Teacher() : base(){
            Position = "Unknown";
            Chair = "Unknown";
            UniName = "Unknown";
        }
        public Teacher(string FirstName, string LastName, string BirthDate, string Chair, string UniName) : base(FirstName, LastName, BirthDate)
        {
            Position = "Lecturer";
            this.Chair = Chair;
            this.UniName = UniName;
        }
        public Teacher(string FirstName, string LastName, string BirthDate, string Position, string Chair, string UniName) : base(FirstName, LastName, BirthDate)
        {
            this.Position = Position;
            this.Chair = Chair;
            this.UniName = UniName;
        }
        public Teacher(Person ojb, Teacher obj) : base(ojb)
        {
            Position = obj.Position;
            Chair = obj.Chair;
            UniName = obj.UniName;
        }
        public void SetPosition(string Position)
        {
            if (Position.Length > 5)
            {
                this.Position = Position;
            }
        }
        public void SetChair(string Chair)
        {
            if (Chair.Length > 5)
            {
                this.Chair = Chair;
            }
        }
        public void SetUniName(string UniName)
        {
            if (UniName.Length > 2)
            {
                this.UniName = UniName;
            }
        }
        public string GetPosition()
        {
            return Position;
        }
        public string GetChair()
        {
            return Chair;
        }
        public string GetUniName()
        {
            return UniName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Iнформацiя про викладача: \n" +
                $"Iм'я: {FirstName};\n" +
                $"Прiзвище: {LastName};\n" +
                $"Дата народження: {BirthDate};\n" +
                $"Посада: {Position};\n" +
                $"Кафедра: {Chair};\n" +
                $"Вищий навчальний заклад: {UniName};\n");
        }
    }
}
