using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.Utils.Data
{
    public static class  DataCalc
    {
        
        public static DateTime getBirthDate(string RFC)
        {
            var datos = RFC.Substring(4, 6);

            var year = datos.Substring(0,2);
            year = (Convert.ToInt32(year) > 30) ? "19"+year : "20"+year;
            var month = datos.Substring(2,2);
            var day = datos.Substring(4,2);

            string birthDateString = $"{year}/{month}/{day}";

            DateTime dt = DateTime.ParseExact(birthDateString, "yyyy/MM/dd", CultureInfo.InvariantCulture);

            return dt;
        }

        public static int daysLived(DateTime birthDate)
        {
            DateTime today = DateTime.Now;
            int days = (today - birthDate).Days;
            return days;
        }

        public static DateTime getFirstDayMonth()
        {
            DateTime today = DateTime.Now;
            var firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            return firstDayOfMonth;
        }
    }
}
