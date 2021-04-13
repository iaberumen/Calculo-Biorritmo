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
using System.Configuration;
using System.Windows;


namespace Calculo_Biorritmo.Screens.Employees
{
    /// <summary>
    /// Lógica de interacción para addEmployee.xaml
    /// </summary>
    public partial class addEmployee : Window
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into empleado (Nombre, RFC, Reloj) values (@nm,@rfc,@reloj);";
                cmd.Parameters.AddWithValue("@nm", tbId.Text);
                cmd.Parameters.AddWithValue("@rfc", tbNoReloj.Text);
                cmd.Parameters.AddWithValue("@reloj", tbRfc.Text);
                cmd.Connection = con;
                int a = cmd.ExecuteNonQuery();

                if (a == 1)
                {
                    MessageBox.Show("Se agrego correctamente");

                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al obtener los datos");
            }
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbNoReloj_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbRfc_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
