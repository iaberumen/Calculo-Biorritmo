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

namespace Calculo_Biorritmo.Screens
{
    /// <summary>
    /// Lógica de interacción para newEmployee.xaml
    /// </summary>
    public partial class newEmployee : UserControl
    {
        public newEmployee()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"tu nombre es {tbNombre.Text}");
        }
    }
}
