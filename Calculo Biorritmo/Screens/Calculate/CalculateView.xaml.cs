using Autofac;
using Calculo_Biorritmo.ApplicationLayer.Queries.Employees.Data;
using Calculo_Biorritmo.Screens.Calculate.BiorytmResults;
using Calculo_Biorritmo.ViewModel;
using MediatR;
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
        private IMediator _mediator;
        public CalculateView()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            _mediator = DIContainer.container.Resolve<IMediator>();
            mainGrid.DataContext = vm;
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                btnSearch_Click(null, null);
        }

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCurp.Text))
                return;

            var response = await _mediator.Send(new GetEmployeeDataGridCommand()
            {
                curp = tbCurp.Text
            });


            if (!response.data.Any())
            {
                MessageBox.Show("No se encontro un empleado registrado con ese curp");
                return;
            }
                

            tbDiasVividos.Text = response.data.Select(x => x.dias_vividos).First().ToString();
            tbFechaNacimiento.Text = response.data.Select(x => x.fecha_nacimiento).First().ToString();
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbCurp.Text = "";
            tbDiasVividos.Text = "";
            tbFechaNacimiento.Text = "";
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            var biorritmoFisico = CalcularBiorritmo(15943,23);
            var biorritmoEmocional = CalcularBiorritmo(15943, 28);
            var biorritmoIntelectual = CalcularBiorritmo(15943, 33);
            var biorritmoIntuicional = CalcularBiorritmo(15943, 38);
            var results = new Results();
            results.ShowDialog(); 
        }

        public List<Double> CalcularBiorritmo(int diasVividos,int teoria)
        {
            List<Double> values = new List<Double>();
            
            for (int i = 0; i < 30; i++)
            {
                var dayValue = (2 * Math.PI * (diasVividos+i))/teoria;
                var sinValue = Math.Sin(dayValue);
                var roundedValue = Math.Round(sinValue, 9, MidpointRounding.ToEven);
                values.Add(roundedValue);
            }
            
            return values;
        }
    }
}
