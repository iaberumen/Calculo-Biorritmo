using OxyPlot;
using OxyPlot.Wpf;
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
using System.Windows.Shapes;

namespace Calculo_Biorritmo.Screens.Calculate.BiorytmResults
{
    /// <summary>
    /// Lógica de interacción para Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public Results(string accidentes, string fechaNacimiento, string curp, List<Double> fisico, List<Double> emocional, List<Double> intelectual, List<Double> intuicional)
        {
            InitializeComponent();
            init();

            lblAccidentes.Content = accidentes;
            lblFechaNacimiento.Content = fechaNacimiento;
            lblCurp.Content = curp;
        }

        public void init()
        {
            var linePoints = new[]
            {
                new DataPoint(1,2),
                new DataPoint(2,1),
            };

            var lineSeries = new LineSeries
            {
                StrokeThickness = 2,
                ItemsSource = linePoints
            };

            var linePoints2 = new[]
            {
                new DataPoint(3,4),
                new DataPoint(4,3),
            };

            var lineSeries2 = new LineSeries
            {
                StrokeThickness = 2,
                ItemsSource = linePoints2
            };

            var linePoints3 = new[]
            {
                new DataPoint(6,8),
                new DataPoint(8,6),
            };

            var lineSeries3 = new LineSeries
            {
                StrokeThickness = 2,
                ItemsSource = linePoints3
            };

            var linePoints4 = new[]
            {
                new DataPoint(10,12),
                new DataPoint(12,10),
            };

            var lineSeries4 = new LineSeries
            {
                StrokeThickness = 2,
                ItemsSource = linePoints4
            };

            asd.Series.Add(lineSeries);
            asd.Series.Add(lineSeries2);
            asd.Series.Add(lineSeries3);
            asd.Series.Add(lineSeries4);
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
