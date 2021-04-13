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
using System.Data;
using System.Data.SqlClient;
using Calculo_Biorritmo.Connection;

namespace Calculo_Biorritmo.Screens.Employees
{
    /// <summary>
    /// Lógica de interacción para EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        public EmployeesView()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            var addNewEmployee = new addEmployee();
            addNewEmployee.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DbClass.openConnectio();
                DbClass.sql = "SELECT * FROM empleado;";
                DbClass.cmd.CommandType = CommandType.Text;
                DbClass.cmd.CommandText = DbClass.sql;

                DbClass.da = new SqlDataAdapter(DbClass.cmd);
                DbClass.dt = new DataTable();
                DbClass.da.Fill(DbClass.dt);

                empleado.ItemsSource = DbClass.dt.DefaultView;
                DbClass.closeConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al obtener los datos");
            }

        }

        private void empleado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
