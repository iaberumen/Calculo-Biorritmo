using Calculo_Biorritmo.ApplicationLayer.Constants;
using Calculo_Biorritmo.Interfaces;
using Calculo_Biorritmo.Utils.Data;
using Calculo_Biorritmo.Screens;
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
using Calculo_Biorritmo.Screens.Employees;
using Calculo_Biorritmo.Screens.Calculate;
using System.Data.SqlClient;
using System.Configuration;
using Calculo_Biorritmo.Screens.Home;
using Calculo_Biorritmo.Screens.Accidents;

namespace Calculo_Biorritmo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        internal void changeView(ISystemView view)
        {
            var control = view;

            gridView.Children.Clear();
            gridView.Children.Add(new HomeView());
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            resetColors();
            Employees.BorderBrush = Brushes.LightBlue;
            gridView.Children.Clear();
            gridView.Children.Add(new EmployeesView());
        }

        private void Biorritm_Click(object sender, RoutedEventArgs e)
        {
            resetColors();
            Biorritm.BorderBrush = Brushes.LightBlue;
            gridView.Children.Clear();
            gridView.Children.Add(new CalculateView());
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            resetColors();
            Main.BorderBrush = Brushes.LightBlue;
            gridView.Children.Clear();
            gridView.Children.Add(new HomeView());
        }

        

        private void Accident_Click(object sender, RoutedEventArgs e)
        {
            resetColors();
            Accident.BorderBrush = Brushes.LightBlue;
            gridView.Children.Clear();
            gridView.Children.Add(new AccidentView());
        }

        private void resetColors()
        {
            Main.BorderBrush = Brushes.Transparent;
            Employees.BorderBrush = Brushes.Transparent;
            Biorritm.BorderBrush = Brushes.Transparent;
            Accident.BorderBrush = Brushes.Transparent;
        }
    }
}
