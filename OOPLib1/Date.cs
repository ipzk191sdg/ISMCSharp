using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib1
{
    public class Date
    {
        public enum Months { January = 1, February, March, April, May, June, July, August, September, October, November, December };
            protected int Year;
            protected Months Month;
            protected int Day;
            protected int Hours;
            protected int Minutes;
            public Date()
            {
                Year = 2019;
                Month = Months.May;
                Day = 1;
                Hours = 8;
                Minutes = 0;
            }
            public Date(Date obj)
            {
                Year = obj.Year;
                Month = obj.Month;
                Day = obj.Day;
                Hours = obj.Hours;
                Minutes = obj.Minutes;
            }
            public Date(int Year, Months Month, int Day, int Hours, int Minutes)
            {
                this.Year = Year;
                this.Month = Month;
                this.Day = Day;
                this.Hours = Hours;
                this.Minutes = Minutes;
            }
            public Date(Months Month, int Day, int Hours, int Minutes)
            {
                Year = 2019;
                this.Month = Month;
                this.Day = Day;
                this.Hours = Hours;
                this.Minutes = Minutes;
            }
            public Date(int Year, Months Month, int Day)
            {
                this.Year = Year;
                this.Month = Month;
                this.Day = Day;
                Hours = 8;
                Minutes = 0;
            }
            public void SetYear(int Year)
            {
                if (Year >= 2019)
                {
                    this.Year = Year;
                }
            }
            public void SetMonth(Months Month)
            {
                this.Month = Month;

            }
            public void SetDay(int Day)
            {
                if (Month == Months.February && Day <= 28)
                {
                    this.Day = Day;
                }
                else if ((Month == Months.April || Month == Months.June || Month == Months.September || Month == Months.November) && Day <= 30)
                {
                    this.Day = Day;
                }
                else if (Day <= 31)
                {
                    this.Day = Day;

                }
            }
            public void SetHours(int Hours)
            {
                if (Hours >= 0 && Hours <= 23)
                {
                    this.Hours = Hours;

                }
            }
            public void SetMinutes(int Minutes)
            {
                if (Minutes < 60 && Minutes >= 0)
                {
                    this.Minutes = Minutes;

                }
            }
            public int GetYear()
            {
                return Year;

            }
            public Months GetMonth()
            {
                return Month;

            }
            public int GetDay()
            {
                return Day;

            }
            public int GetHours()
            {
                return Hours;

            }
            public int GetMinutes()
            {
                return Minutes;
            }
        }
    }