using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace Calculo_Biorritmo.Connection
{
    class DbClass
    {
        public static string GetConnectionStrings()
        {
            string strConString = ConfigurationManager.ConnectionStrings["conString"].ToString();
            return strConString;
        }

        public static string sql;
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand("", con);
        public static SqlDataReader rd;
        public static DataTable dt;
        public static SqlDataAdapter da;

        public static void openConnectio()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = GetConnectionStrings();
                    con.Open();
                }

                if (con.State == ConnectionState.Open)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ToString();
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM empleado;";
                    cmd.Connection = con;
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        MessageBox.Show("No existe la Base de Datos");

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("El sistema fallo al conectar a la base de datos." + Environment.NewLine +
                                "Descriptions: " + ex.Message.ToString(), "C# WPF Connect to SQL Server",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        public static void closeConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                //
            }
        }
    }
}
