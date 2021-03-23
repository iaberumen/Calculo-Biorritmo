using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.Models
{
    public class Employee
    {
        public Employee(string id,string name, string NSS, string RFC)
        {
            this.id = id;
            this.name = name;
            this.NSS = NSS;
            this.RFC = RFC;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string NSS { get; set; }
        public string RFC { get; set; }
    }
}
