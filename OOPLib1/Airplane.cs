using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;
        public Airplane() {
            StartCity = "Zhytomyr";
            FinishCity = "Kiyv";
            StartDate = new Date();
            FinishDate = new Date();
        }
        public Airplane(Airplane obj)
        {
            StartCity = obj.StartCity;
            FinishCity = obj.FinishCity;
            StartDate = new Date(obj.StartDate);
            FinishDate = new Date(obj.FinishDate);
        }
        public Airplane(string StartCity, string FinishCity, Date StartDate, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            this.StartDate = new Date(StartDate);
            this.FinishDate = new Date(FinishDate);
        }
        public Airplane(string FinishCity, Date StartDate, Date FinishDate)
        {
            StartCity = "Zhytomyr" +
                "";
            this.FinishCity = FinishCity;
            this.StartDate = new Date(StartDate);
            this.FinishDate = new Date(FinishDate);
        }
        public Airplane(string StartCity, string FinishCity, Date FinishDate)
        {
            this.StartCity = StartCity;
            this.FinishCity = FinishCity;
            StartDate = new Date();
            this.FinishDate = new Date(FinishDate);
        }
        public void SetStartCity (string StartCity)
        {
            if(StartCity.Length > 0)
            {
                this.StartCity = StartCity;
           
 }
        }
        public void SetFinishCity(string FinishCity)
        {
            if (FinishCity.Length > 0)
            {
                this.FinishCity = FinishCity;
            }
        }
        public string GetStartCity()
        {
            return StartCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;   
        }
        public Date GetStartDate() { return StartDate; }
        public Date GetFinishDate() { return FinishDate; }
        public int GetTotalTime()
        {
            int tripLength = 0;
            int startMinutes = StartDate.GetMinutes(); int finishMinutes = FinishDate.GetMinutes();
            int startHours = StartDate.GetHours(); int finishHours = FinishDate.GetHours();
            int startDay = StartDate.GetDay(); int finishDay = FinishDate.GetDay();
            if(startDay==finishDay) tripLength = (finishMinutes + finishHours * 60) - (startMinutes + startHours * 60);
            else tripLength = (finishMinutes + finishHours * 60+(finishDay-startDay)*24*60) - (startMinutes + startHours * 60);
            return tripLength;
        }
        public bool IsArrivingToday()
        {
            int startDay = StartDate.GetDay(); int finishDay = FinishDate.GetDay();
            if (startDay == finishDay) return true;
            else return false;
        }
    }
}
