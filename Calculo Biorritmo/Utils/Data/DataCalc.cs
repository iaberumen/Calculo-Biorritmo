using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.Utils.Data
{
    public static class  DataCalc
    {
        
        
        public static void getBirthDate(String RFC)
        {
            var datos = RFC.Substring(4, 9);

            var year = "19"+datos.Substring(0,1);
            var month = datos.Substring(2,3);
            var day = datos.Substring(4,5);


        }
    }
}
