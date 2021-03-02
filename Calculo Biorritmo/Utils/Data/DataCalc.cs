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

            var year = "19"+datos.Substring(0,2);
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
    }
}
