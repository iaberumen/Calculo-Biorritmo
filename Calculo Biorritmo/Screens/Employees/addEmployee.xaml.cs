﻿using System;
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
