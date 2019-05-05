using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Student : Person
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string UniName;
        public Student() : base()
        {
            Course = 0;
            Group = "Unknown";
            Faculty = "Unknown";
            UniName = "Unknown";
        }
        public Student(string FirstName, string LastName, string BirthDate, string Group, string Faculty, string UniName) : base(FirstName, LastName, BirthDate)
        {
            Course = 1;
            this.Group = Group;
            this.Faculty = Faculty;
            this.UniName = UniName;
        }
        public Student(string FirstName, string LastName, string BirthDate, int Course, string Group, string Faculty, string UniName) : base(FirstName, LastName, BirthDate)
        {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.UniName = UniName;
        }
        public Student(Person ojb, Student obj) : base(ojb)
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            UniName = obj.UniName;
        }
        public void SetCourse(int Course)
        {
            if (Course > 0 && Course != 0)
            {
                this.Course = Course;
            }
        }
        public void SetGroup(string Group)
        {
            if (Group.Length > 2)
            {
                this.Group = Group;
            }
        }
        public void SetFaculty(string Faculty)
        {
            if(Faculty.Length > 2)
            {
                this.Faculty = Faculty;
            }
        }
        public void SetUniName(string UniName)
        {
            if (UniName.Length > 2)
            {
                this.UniName = UniName;
            }
        }
        public int GetCourse()
        {
            return Course;
        }
        public string GetGroup()
        {
            return Group;
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public string GetUniName()
        {
            return UniName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Iнформацiя про студента:\n" +
                $"Iм'я: {FirstName};\n" +
                $"Прiзвище: {LastName};\n" +
                $"Дата народження: {BirthDate};\n" +
                $"Курс: {Course};\n" +
                $"Група: {Group};\n" +
                $"Факультет: {Faculty};\n" +
                $"Вищий навчальний заклад: {UniName};\n");
        }
    }
}
