using Calculo_Biorritmo.ApplicationLayer.Constants;
using Calculo_Biorritmo.Data;
using Calculo_Biorritmo.Models;
using Calculo_Biorritmo.Utils.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            MessageBox.Show(promedioFisico.ToString());
            MessageBox.Show(promedioEmocional.ToString());
            MessageBox.Show(promedioIntelectual.ToString());
            MessageBox.Show(promedioIntuicional.ToString());

        }

        public static void checkCritics()
        {
            var accidentes = new List<accident>();
            using (var ctx = new EmployeeEntity())
                foreach (var item in ctx.accidents.ToList())
                    accidentes.Add(item);

            if (!accidentes.Any())
                return;

            MessageBox.Show(accidentes.Count.ToString());

            var accidentOnCritic = new List<accident>();
            var accidentOnPerfectCritics = new List<accident>();
            var ocurredOnFisic = new List<Double?>();
            var ocurredOnEmotional = new List<Double?>();
            var ocurredOnIntuitional = new List<Double?>();
            var ocurredOnIntelectual = new List<Double?>();

            foreach (var item in accidentes)
            {
                var date = DataCalc.getBirthDate(item.curp);
                var days = DataCalc.daysLived(date,item.fecha_accidente);
                var RegistrosFisicos = DataCalc.CalculateBiorritm(days,BiorytmDays.biorritmo_fisico);
                var wasFisicCritic =  calculateCritics(RegistrosFisicos);
                if (wasFisicCritic != null)
                    ocurredOnFisic.Add(wasFisicCritic);
                var RegistrosEmocionales = DataCalc.CalculateBiorritm(days, BiorytmDays.biorritmo_emocional);
                var wasEmotionalCritic = calculateCritics(RegistrosEmocionales);
                if (wasEmotionalCritic != null)
                    ocurredOnEmotional.Add(wasEmotionalCritic);
                var RegistrosIntuicionales = DataCalc.CalculateBiorritm(days, BiorytmDays.biorritmo_intuicional);
                var wasIntuitionalCritic = calculateCritics(RegistrosIntuicionales);
                if (wasIntuitionalCritic != null)
                    ocurredOnIntuitional.Add(wasIntuitionalCritic);
                var RegistrosIntelectuales = DataCalc.CalculateBiorritm(days, BiorytmDays.biorritmo_intelectual);
                var wasIntelectualCritic = calculateCritics(RegistrosIntelectuales);
                if (wasIntelectualCritic != null)
                    ocurredOnIntelectual.Add(wasIntelectualCritic);

                if (wasFisicCritic != null ||
                   wasEmotionalCritic != null ||
                   wasIntelectualCritic != null ||
                   wasIntuitionalCritic != null)
                {
                    accidentOnCritic.Add(item);
                    if (wasFisicCritic != null &&
                   wasEmotionalCritic != null &&
                   wasIntelectualCritic != null &&
                   wasIntuitionalCritic != null)
                        accidentOnPerfectCritics.Add(item);
                }
                    
            }
            MessageBox.Show(ocurredOnFisic.Count.ToString());
            MessageBox.Show(ocurredOnEmotional.Count.ToString());
            MessageBox.Show(ocurredOnIntuitional.Count.ToString());
            MessageBox.Show(ocurredOnIntelectual.Count.ToString());
            MessageBox.Show(accidentOnPerfectCritics.Count.ToString());
            MessageBox.Show(accidentOnCritic.Count.ToString());


        }

        public static double? calculateCritics(List<Double> List)
        {
            if (List[1] == 0)
                return List[1];
            /*else if (List[0] == 0)
                return List[1];
            else if (List[2] == 0)
                return List[1];
            else if (List[0] > 0 && List[1] < 0)
                return List[1];
            else if (List[0] < 0 && List[1] > 0)
                return List[1];
            else if (List[1] < 0 && List[2] > 0)
                return List[1];
            else if (List[1] > 0 && List[2] < 0)
                return List[1];*/
            return null;
        }
    }
}
