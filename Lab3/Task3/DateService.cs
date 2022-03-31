using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DateService
    {
       public static DayOfWeek GetDay(string date)
        {
            int day = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(3, 2));
            int year= Convert.ToInt32(date.Substring(6, 4));
            DateTime DT=new DateTime(year,month,day);           
            return DT.DayOfWeek;
        }

        public static int GetDaysSpan(int day,int month,int year)
        {
            DateTime dt = DateTime.Now;
            string currentDay = dt.ToShortDateString();
            int day1 = Convert.ToInt32(currentDay.Substring(0, 2));
            int month1 = Convert.ToInt32(currentDay.Substring(3, 2));
            int year1 = Convert.ToInt32(currentDay.Substring(6, 4));
            int duration = Math.Abs(day - day1 + month - month1 + year - year1);
            return duration;
        }
    }
}
