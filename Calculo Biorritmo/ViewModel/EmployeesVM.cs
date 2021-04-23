using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Biorritmo.ViewModel
{
    class EmployeesVM
    {
        public int id { get; set; }
        public string curp { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public int dia { get; set; }
        public DateTime fecha_accidente { get; set; }
        public int anio_acc { get; set; }
        public int mes_acc { get; set; }
        public int dia_acc { get; set; }
        public int dias_vividos { get; set; }
        public int residuo_fisico { get; set; }
        public int residuo_emocional { get; set; }
        public int residuo_intelectual { get; set; }
        public int residuo_intuicional { get; set; }
    }
}
