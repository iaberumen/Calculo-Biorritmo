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
using Calculo_Biorritmo.Connection;
using System.Configuration;
using MediatR;
using Calculo_Biorritmo.ApplicationLayer.UseCases.Employee.CreateEmployee;
using Calculo_Biorritmo.ViewModel;
using Calculo_Biorritmo.Utils.Data;
using Autofac;

namespace Calculo_Biorritmo.Screens.Employees
{
    /// <summary>
    /// Lógica de interacción para addEmployee.xaml
    /// </summary>
    public partial class addEmployee : Window
    {
        EmployeesVM vm = new EmployeesVM();
        private IMediator _mediator;
        public addEmployee()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            gridForm.DataContext = vm;
            tbFechaAccidente.SelectedDate = DateTime.Now;
            _mediator = DIContainer.container.Resolve<IMediator>();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            vm.fecha_nacimiento = tbFechaAccidente.SelectedDate ?? DateTime.Now;
            vm.fecha_accidente = tbFechaAccidente.SelectedDate ?? DateTime.Now;
            var createCommand = new CreateEmployeeCommand(vm.curp, vm.fecha_nacimiento, vm.fecha_accidente);
            await _mediator.Send(createCommand);
            Close();
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
