﻿using Calculo_Biorritmo.Algorytms;
using Calculo_Biorritmo.ApplicationLayer.Constants;
using Calculo_Biorritmo.Data;
using Calculo_Biorritmo.Extensions.ContextExtensions;
using Calculo_Biorritmo.Models;
using Calculo_Biorritmo.Utils.Data;
using Calculo_Biorritmo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculo_Biorritmo.Screens.Home
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            int totalRegisters;
            int totalAccidents;
            var accidents = new List<AccidentsVM>();
            var accidentes = new List<accident>();
            var employees = new List<employee>();

            using (var ctx = new EmployeeEntity())
                employees = ctx.employees.ToList();

            int i = 0;

            foreach(var employee in employees)
            {
                var birthDate = DataCalc.getBirthDate(employee.curp);
                var LivingDays = DataCalc.daysLived(birthDate);

                accidents.Add(new AccidentsVM(i, 
                    employee.curp,
                    employee.fecha_nacimiento,
                    CalcBiorrytm(LivingDays, BiorytmDays.biorritmo_fisico),
                    CalcBiorrytm(LivingDays, BiorytmDays.biorritmo_emocional),
                    CalcBiorrytm(LivingDays, BiorytmDays.biorritmo_intelectual),
                    CalcBiorrytm(LivingDays, BiorytmDays.biorritmo_intuicional)));

                i++;
            }


            using (var ctx = new EmployeeEntity())
                totalRegisters = ctx.employees.totalRegisters();
            using (var ctx = new EmployeeEntity())
                totalAccidents = ctx.accidents.totalAccidents();

            lbAccidentNum.Content = totalAccidents.ToString();
            lbEmployeeNum.Content = totalRegisters.ToString();

            empleado.ItemsSource = accidents;

            var totalriskEmployees = empleado.Items.Count;

            lbltotalRiskEmployees.Content = totalriskEmployees;
        }

        public double CalcBiorrytm(int LivingDays,int teoria)
        {
            var dayValue = (2 * Math.PI * (LivingDays)) / teoria;
            var sinValue = Math.Sin(dayValue);
            var roundedValue = Math.Round(sinValue, 9, MidpointRounding.ToEven);
            return roundedValue;
        }
    }
}
