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
        public Results()
        {
            InitializeComponent();
            init();
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

            asd.Series.Add(lineSeries);
        }
    }
}
