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
            Console.WriteLine("Введiть кiлькiсть елементiв масиву:");
            bool test = Int32.TryParse(Console.ReadLine(), out n);
            while (!test&&n<=100) { Console.WriteLine("Введiть цiле число:"); test = Int32.TryParse(Console.ReadLine(), out n); }
            Airplane[] airplane = new Airplane[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Введiть мiсто вiдправлення:");
            string StartCity = Console.ReadLine();
                Console.WriteLine("Введiть мiсце призначення:");
                string FinishCity = Console.ReadLine();
            int startYear, startMonth, startDay, startHours, startMinutes;
            int finishYear, finishMonth, finishDay, finishHours, finishMinutes;
                Console.WriteLine("Введiть рiк вiдправлення:");
                bool testStartYear = Int32.TryParse(Console.ReadLine(), out startYear);
                while (!testStartYear&&startYear>=2019) {
                    Console.WriteLine("Рiк має бути цiлим числом.");
                    testStartYear = Int32.TryParse(Console.ReadLine(), out startYear); }
                Console.WriteLine("Введiть мiсяць вiдправлення:");
                bool testStartMonth = Int32.TryParse(Console.ReadLine(), out startMonth);
                while (!testStartMonth&&startMonth>0&&startMonth!=0&&startMonth<13) {
                    Console.WriteLine("Мiсяць має бути цiлим числом.");
                    testStartMonth = Int32.TryParse(Console.ReadLine(), out startMonth); }
                Console.WriteLine("Введiть день вiдправлення:");
                bool testStartDay = Int32.TryParse(Console.ReadLine(), out startDay);
                while (!testStartDay&&startDay>0&&startDay!=0&&startDay<31) {
                    if (startMonth == 2 && startDay > 29) Console.WriteLine("");
                    else if ((startMonth == 4 || startMonth == 6 || startMonth == 9 || startMonth == 11) && startDay > 30) Console.WriteLine("");
                    Console.WriteLine("День має бути цiлим числом.");
                    testStartDay = Int32.TryParse(Console.ReadLine(), out startDay); }
                Console.WriteLine("Введiть час вiдправлення:\n Години:");
                bool testStartHours = Int32.TryParse(Console.ReadLine(), out startHours);
                while (!testStartHours) {
                    Console.WriteLine("Години повиннi бути цiлим числом.");
                    testStartHours = Int32.TryParse(Console.ReadLine(), out startHours); }
                Console.WriteLine("Хвилини:");
                bool testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes);
                while (!testStartMinutes) {
                    Console.WriteLine("Хвилини повиннi бути цiлим числом.");
                    testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes); }
            Date startDate = new Date(startYear, (Date.Months)startMonth, startDay, startHours, startMinutes);
                Console.WriteLine("Введiть рiк прибуття:");
                bool testFinishYear = Int32.TryParse(Console.ReadLine(), out finishYear);
                while (!testFinishYear) {
                    Console.WriteLine("Рiк має бути цiлим числом.");
                    testStartYear = Int32.TryParse(Console.ReadLine(), out finishYear); }
                Console.WriteLine("Введiть мiсяць прибуття:");
                bool testFinishMonth = Int32.TryParse(Console.ReadLine(), out finishMonth);
                while (!testFinishMonth) {
                    Console.WriteLine("Мiсяць має бути цiлим числом.");
                    testStartMonth = Int32.TryParse(Console.ReadLine(), out finishMonth); }
                Console.WriteLine("Введiть день прибуття:");
                bool testFinishDay = Int32.TryParse(Console.ReadLine(), out finishDay);
                while (!testFinishDay) {
                    Console.WriteLine("День має бути цiлим числом:");
                    testStartDay = Int32.TryParse(Console.ReadLine(), out finishDay); }
                Console.WriteLine("Введiть час прибуття:\nГодини:");
                bool testFinishHours = Int32.TryParse(Console.ReadLine(), out finishHours);
                while (!testFinishHours) {
                    Console.WriteLine("Години повиннi бути цiлим числом.");
                    testStartHours = Int32.TryParse(Console.ReadLine(), out finishHours); }
                Console.WriteLine("Хвилини:");
                bool testFinishMinutes = Int32.TryParse(Console.ReadLine(), out finishMinutes);
                while (!testStartMinutes) {
                    Console.WriteLine("Хвилини повиннi бути цiлим числом.");
                    testStartMinutes = Int32.TryParse(Console.ReadLine(), out startMinutes); }
            Date finishDate = new Date(finishYear, (Date.Months)finishMonth, finishDay, finishHours, finishMinutes);
            airplane[i] = new Airplane(StartCity, FinishCity, startDate, finishDate);
            }
            return airplane;
        }
        static void PrintAirplane(Airplane airpln)
        {
            Console.WriteLine($"Мiсто вiдправлення: {airpln.GetStartCity().ToString()}, " +
                $"мiсто прибуття: {airpln.GetFinishCity().ToString()}, \n" +
                $"дата вiдправлення: {airpln.GetStartDate().GetYear()}.{airpln.GetStartDate().GetMonth()}.{airpln.GetStartDate().GetDay()} " +
                $"час вiдправлення: {airpln.GetStartDate().GetHours()}:{airpln.GetStartDate().GetMinutes()}, \n" +
                $"дата прибуття: {airpln.GetFinishDate().GetYear()}.{airpln.GetFinishDate().GetMonth()}.{airpln.GetFinishDate().GetDay()}, " +
                $"час прибуття: {airpln.GetFinishDate().GetHours()}:{airpln.GetFinishDate().GetMinutes()}.");
        }
        static void PrintAirplanes(Airplane[] airpln)
        {
            for(int i=0; i<airpln.Length; i++)
                Console.WriteLine($"Мiсто вiдправлення: {airpln[i].GetStartCity().ToString()}, " +
                    $"мiсто прибуття: {airpln[i].GetFinishCity().ToString()}, \n" +
                    $"дата вiдправлення: {airpln[i].GetStartDate().GetYear()}.{airpln[i].GetStartDate().GetMonth()}.{airpln[i].GetStartDate().GetDay()} " +
                    $"час вiдправлення: {airpln[i].GetStartDate().GetHours()}:{airpln[i].GetStartDate().GetMinutes()}, \n" +
                    $"дата прибуття: {airpln[i].GetFinishDate().GetYear()}.{airpln[i].GetFinishDate().GetMonth()}.{airpln[i].GetFinishDate().GetDay()}, " +
                    $"час прибуття: {airpln[i].GetFinishDate().GetHours()}:{airpln[i].GetFinishDate().GetMinutes()}.");
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
