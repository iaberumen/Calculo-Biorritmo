using Calculo_Biorritmo.Screens.Calculate.BiorytmResults;
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

namespace Calculo_Biorritmo.Screens.Calculate
{
    /// <summary>
    /// Lógica de interacción para CalculateView.xaml
    /// </summary>
    public partial class CalculateView : UserControl
    {
        EmployeesVM vm = new EmployeesVM();
        public CalculateView()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            mainGrid.DataContext = vm;
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var results = new Results();
            results.ShowDialog();
        }
    }
}
