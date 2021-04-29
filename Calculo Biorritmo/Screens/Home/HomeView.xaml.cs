using Calculo_Biorritmo.Data;
using Calculo_Biorritmo.Extensions.ContextExtensions;
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
            int registers;
            int accidents;

            using (var ctx = new EmployeeEntity())
                registers = ctx.employees.totalRegisters();
            using (var ctx = new EmployeeEntity())
                accidents = ctx.employees.totalAccidents();

            lbAccidentNum.Content = accidents.ToString();
            lbEmployeeNum.Content = registers.ToString();
        }
    }
}
