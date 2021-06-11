using Calculo_Biorritmo.Algorytms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
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

namespace Calculo_Biorritmo.Screens.Calculate.BiorytmResults
{
    /// <summary>
    /// Lógica de interacción para EmployeeBiorytm.xaml
    /// </summary>
    public partial class EmployeeBiorytm : UserControl
    {
        Random r = new Random();
        Generadora generador;
        private string _livingDays;
        public EmployeeBiorytm(string livingDays)
        {
            InitializeComponent();
            generador = new Generadora();
            _livingDays = livingDays;
            init();
        }

        public void init()
        {
            generador.CalcularBiorritmo(Convert.ToInt32(_livingDays), 28);
            //Tabla.ItemsSource = null;
            //Tabla.ItemsSource = generador.Puntos;
            PlotModel model = new PlotModel();
            LinearAxis ejeX = new LinearAxis();
            ejeX.Minimum = double.Parse(_livingDays);
            ejeX.Maximum = double.Parse(_livingDays);
            ejeX.Position = AxisPosition.Bottom;

            LinearAxis ejeY = new LinearAxis();
            ejeY.Minimum = generador.Puntos.Min(p => p.Y);
            ejeY.Maximum = generador.Puntos.Max(p => p.Y);
            ejeY.Position = AxisPosition.Left;

            model.Axes.Add(ejeX);
            model.Axes.Add(ejeY);
            model.Title = "Datos generados";
            LineSeries linea = new LineSeries();
            foreach (var item in generador.Puntos)
            {
                linea.Points.Add(new DataPoint(item.X, item.Y));
            }
            linea.Title = "Valores generados";
            linea.Color = OxyColor.FromRgb(byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()), byte.Parse(r.Next(0, 255).ToString()));
            model.Series.Add(linea);
            asd.Model = model;
        }

    }
}
