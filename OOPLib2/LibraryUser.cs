using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib2
{
    public class LibraryUser : Person
    {
        protected int ReaderTicketNumber;
        protected string DateOfIssue;
        protected double MonthlyReaderFee;
        public LibraryUser() : base()
        {
            ReaderTicketNumber = 0;
            DateOfIssue = "05.05.2019";
            MonthlyReaderFee = 0.0;
        }
        public LibraryUser(string FirstName, string LastName, string BirthDate, int ReaderTicketNumber, string DateOfIssue) : base(FirstName, LastName, BirthDate)
        {
            this.ReaderTicketNumber = ReaderTicketNumber;
            this.DateOfIssue = DateOfIssue;
            MonthlyReaderFee = 0.0;
        }
        public LibraryUser(string FirstName, string LastName, string BirthDate, int ReaderTicketNumber, string DateOfIssue, double MonthlyReaderFee) : base(FirstName, LastName, BirthDate)
        {
            this.ReaderTicketNumber = ReaderTicketNumber;
            this.DateOfIssue = DateOfIssue;
            this.MonthlyReaderFee = MonthlyReaderFee;
        }
        public LibraryUser(Person ojb, LibraryUser obj) : base(ojb)
        {
            ReaderTicketNumber = obj.ReaderTicketNumber;
            DateOfIssue = obj.DateOfIssue;
            MonthlyReaderFee = obj.MonthlyReaderFee;
        }
        public void SetReaderTicketNumber(int ReaderTicketNumber)
        {
            if (ReaderTicketNumber > 0 && ReaderTicketNumber != 0)
            {
                this.ReaderTicketNumber = ReaderTicketNumber;
            }
        }
        public void SetDateOfIssue(string DateOfIssue)
        {
            if (DateOfIssue.Length == 10)
            {
                this.DateOfIssue = DateOfIssue;
            }
        }
        public void SetMonthlyReaderFee(double MonthlyReaderFee)
        {
            if (MonthlyReaderFee > 0)
            {
                this.MonthlyReaderFee = MonthlyReaderFee;
            }
        }
        public int GetReaderTicketNumber()
        {
            return ReaderTicketNumber;
        }
        public string GetDateOfIssue()
        {
            return DateOfIssue;
        }
        public double GetMonthlyReaderFee()
        {
            return MonthlyReaderFee;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Iнформацiя про користувача бiблiотекою:\n" +
                $"Iм'я: {FirstName};\n" +
                $"Прiзвище: {LastName};\n" +
                $"Дата народження: {BirthDate};\n" +
                $"Номер читацького квитка: {ReaderTicketNumber};\n" +
                $"Дата видачi: {DateOfIssue};\n" +
                $"Розмiр щомiсячного читацького внеску: {MonthlyReaderFee};\n");
        }
    }
}
