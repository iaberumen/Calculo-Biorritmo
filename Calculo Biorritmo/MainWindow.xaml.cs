using Calculo_Biorritmo.Utils.Data;
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

        private void obtenerRFC_click(object sender, RoutedEventArgs e)
        {
            tbkRfc.Text = DataCalc.getBirthDate(rfc_input.Text).ToString("yyyy-MM-dd");
            tbkLivingDays.Text = ""+DataCalc.daysLived(DataCalc.getBirthDate(rfc_input.Text));
            tbkFirstDayMonth.Text = "" + DataCalc.getFirstDayMonth().ToString("yyyy-MM-dd");
            grdRFC.Visibility = Visibility.Visible;
        }
    }
}
