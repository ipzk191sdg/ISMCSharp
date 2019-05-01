using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib1;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static Airplane[] ReadAirplaneArray()
        {
            int n;
            bool test = Int32.TryParse(Console.ReadLine(), out n);
            while (!test) { test = Int32.TryParse(Console.ReadLine(), out n); }
            Airplane[] airplane = new Airplane[n];
            for(int i = 0; i<n; i++)
            {
            string StartCity = Console.ReadLine();
            string FinishCity = Console.ReadLine();
            int startYear, startMonth, startDay, startHours, startMinutes;
            int finishYear, finishMonth, finishDay, finishHours, finishMinutes;
            bool testStartYear = Int32.TryParse(Console.ReadLine(), out startYear);
            bool testStartMonth = Int32.TryParse(Console.ReadLine(), out startMonth);
            bool testStartDay = Int32.TryParse(Console.ReadLine(), out startDay);
            bool testStartHours = Int32.TryParse(Console.ReadLine(), out startHours);
            bool testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes);
            while (!testStartYear) { testStartYear = Int32.TryParse(Console.ReadLine(), out startYear); }
            while (!testStartMonth) { testStartMonth = Int32.TryParse(Console.ReadLine(), out startMonth); }
            while (!testStartDay) { testStartDay = Int32.TryParse(Console.ReadLine(), out startDay); }
            while (!testStartHours) { testStartHours = Int32.TryParse(Console.ReadLine(), out startHours); }
            while (!testStartMinutes) { testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes); }
            Date startDate = new Date(startYear, (Date.Months)startMonth, startDay, startHours, startMinutes);
            bool testFinishYear = Int32.TryParse(Console.ReadLine(), out finishYear);
            bool testFinishMonth = Int32.TryParse(Console.ReadLine(), out finishMonth);
            bool testFinishDay = Int32.TryParse(Console.ReadLine(), out finishDay);
            bool testFinishHours = Int32.TryParse(Console.ReadLine(), out finishHours);
            bool testFinishMinutes = Int32.TryParse(Console.ReadLine(), out finishMinutes);
            while (!testFinishYear) { testStartYear = Int32.TryParse(Console.ReadLine(), out finishYear); }
            while (!testFinishMonth) { testStartMonth = Int32.TryParse(Console.ReadLine(), out finishMonth); }
            while (!testFinishDay) { testStartDay = Int32.TryParse(Console.ReadLine(), out finishDay); }
            while (!testFinishHours) { testStartHours = Int32.TryParse(Console.ReadLine(), out finishHours); }
            while (!testStartMinutes) { testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes); }
            Date finishDate = new Date(finishYear, (Date.Months)finishMonth, finishDay, finishHours, finishMinutes);
            airplane[i] = new Airplane(StartCity, FinishCity, startDate, finishDate);
            }
            return airplane;
        }
        static void PrintAirplane(Airplane airpln)
        {
            Console.WriteLine($"{airpln.GetStartCity().ToString()}, {airpln.GetFinishCity().ToString()}, {airpln.GetStartDate().ToString()}, {airpln.GetFinishDate().ToString()}");
        }
        static void PrintAirplanes(Airplane[] airpln)
        {
            for(int i=0; i<airpln.Length; i++)
            Console.WriteLine($"{airpln[i].GetStartCity().ToString()}, {airpln[i].GetFinishCity().ToString()}, {airpln[i].GetStartDate().ToString()}, {airpln[i].GetFinishDate().ToString()}");
        }
        static void GetAirplaneInfo(Airplane[] airpln, out int maxLength, out int minLength)
        {
            int[] tripsLength = new int[airpln.Length];
            maxLength = Int32.MinValue;
            minLength = Int32.MaxValue;
            for (int i = 0; i < tripsLength.Length; i++)
                tripsLength[i] = airpln[i].GetTotalTime();
            for (int i = 0; i < tripsLength.Length; i++) {
                if (tripsLength[i] > maxLength) maxLength = tripsLength[i];
                if (tripsLength[i] < minLength) minLength = tripsLength[i];
             }
        }
        static void SortAirplanesByDate(ref Airplane[] airpln)
        {
            var result = from airplane in airpln
                         orderby airplane.GetStartDate().GetYear(), airplane.GetStartDate().GetMonth(), airplane.GetStartDate().GetDay(), airplane.GetStartDate().GetHours(), airplane.GetStartDate().GetMinutes() descending
                         select airplane;
        }
        static void SortAirplanesByTotalTime(ref Airplane[] airpln)
        {
            var result = airpln.OrderBy(tripLength => tripLength.GetTotalTime());
        }
    }
}
