using Calculo_Biorritmo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.Extensions.ContextExtensions
{
    static class EmployeeExtensions
    {
        public static int totalRegisters(this DbSet<employee> employees)
        {
            return employees.Count();
        }

        public static int totalAccidents(this DbSet<employee> employees)
        {
            return employees.Where(x => x.fecha_accidente != null).Count();
        }

        public static int totalAccidentsByCurp(this DbSet<employee> employees, string curp)
        {
            return employees.Where(x => x.curp == curp).Count();
        }
    }
}
