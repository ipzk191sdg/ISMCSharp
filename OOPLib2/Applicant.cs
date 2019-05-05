using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class Applicant : Person
    {
        protected double ZNOPoints;
        protected double EdPoints;
        protected string SchoolName;
        public Applicant() : base()
        {
            ZNOPoints = 0.0;
            EdPoints = 0.0;
            SchoolName = "Unknown";
        }
        public Applicant(string FirstName, string LastName, string BirthDate, string SchoolName) : base(FirstName, LastName, BirthDate)
        {
            ZNOPoints = 225;
            EdPoints = 8;
            this.SchoolName = SchoolName;
        }
        public Applicant(string FirstName, string LastName, string BirthDate, double ZNOPoints, double EdPoints, string SchoolName) : base(FirstName, LastName, BirthDate)
        {
            this.ZNOPoints = ZNOPoints;
            this.EdPoints = EdPoints;
            this.SchoolName = SchoolName;
        }
        public Applicant(Person ojb, Applicant obj) : base(ojb)
        {
            ZNOPoints = obj.ZNOPoints;
            EdPoints = obj.EdPoints;
            SchoolName = obj.SchoolName;
        }
        public void SetZNOPoints(double ZNOPoints)
        {
            if (ZNOPoints > 0 && ZNOPoints != 0)
            {
                this.ZNOPoints = ZNOPoints;
            }
        }
        public void SetEdPoints(double EdPoints)
        {
            if (EdPoints > 0 && EdPoints != 0)
            {
                this.EdPoints = EdPoints;
            }
        }
        public void SetSchoolName(string SchoolName)
        {
            if (SchoolName.Length > 2)
            {
                this.SchoolName = SchoolName;
            }
        }
        public double GetZNOPoints()
        {
            return ZNOPoints;
        }
        public double GetEdPoints()
        {
            return EdPoints;
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Iнформацiя про абiтурiєнта:\n" +
                $"Iм'я: {FirstName};\n" +
                $"Прiзвище: {LastName};\n" +
                $"Дата народження: {BirthDate};\n" +
                $"Кiлькiсть балiв сертифiкатiв ЗНО: {ZNOPoints};\n" +
                $"Kiлькiсть балiв за документ про освiту: {EdPoints};\n" +
                $"Hазва загальноосвiтнього навчального закладу: {SchoolName};\n");
        }
    }
}
