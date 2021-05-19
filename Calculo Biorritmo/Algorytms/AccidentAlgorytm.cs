using Calculo_Biorritmo.Data;
using Calculo_Biorritmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculo_Biorritmo.Algorytms
{
    class AccidentAlgorytm
    {
        public static void startAlgorytm()
        {
            var accidentes =  new List<accident>();
            using (var ctx = new EmployeeEntity())
                foreach (var item in ctx.accidents.ToList())
                    accidentes.Add(item);

            if (!accidentes.Any())
                return;

            var RegistrosFisicos = new List<Double>();
            var RegistrosEmocionales = new List<Double>();
            var RegistrosIntuicionales = new List<Double>();
            var RegistrosIntelectuales = new List<Double>();

            foreach (var biorritmo in accidentes){
                RegistrosFisicos.Add(biorritmo.residuo_fisico);
                RegistrosEmocionales.Add(biorritmo.residuo_emocional);
                RegistrosIntelectuales.Add(biorritmo.residuo_intelectual);
                RegistrosIntuicionales.Add(biorritmo.residuo_intuicional);
            }

            var totalFisico = RegistrosFisicos.Sum();
            var promedioFisico = totalFisico / RegistrosFisicos.Count;
            var totalEmocional = RegistrosEmocionales.Sum();
            var promedioEmocional = totalEmocional / RegistrosEmocionales.Count;
            var totalIntelectual= RegistrosIntelectuales.Sum();
            var promedioIntelectual = totalIntelectual / RegistrosIntelectuales.Count;
            var totalIntuicional = RegistrosIntuicionales.Sum();
            var promedioIntuicional = totalIntuicional / RegistrosIntuicionales.Count;


        }

    }
}
