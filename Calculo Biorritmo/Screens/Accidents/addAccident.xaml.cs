using Autofac;
using Calculo_Biorritmo.ApplicationLayer.UseCases.Accident;
using Calculo_Biorritmo.Utils.Data;
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
using System.Windows.Shapes;

namespace Calculo_Biorritmo.Screens.Accidents
{
    /// <summary>
    /// Lógica de interacción para addAccident.xaml
    /// </summary>
    public partial class addAccident : Window
    {
        AccidentsVM vm = new AccidentsVM();
        private IMediator _mediator;
        public addAccident()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            gridForm.DataContext = vm;
            _mediator = DIContainer.container.Resolve<IMediator>();
        }

        private async void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (tbFechaAccidente.SelectedDate == null)
            {
                MessageBox.Show("La fecha del accidente no puede ser vacia");
                return;
            }

            int dias = DataCalc.daysLived(vm.fecha_accidente);
            var biorritmoFisico = CalcularBiorritmo(dias, 23);
            var biorritmoEmocional = CalcularBiorritmo(dias, 28);
            var biorritmoIntelectual = CalcularBiorritmo(dias, 33);
            var biorritmoIntuicional = CalcularBiorritmo(dias, 38);

            var createCommand = new RegisterAccidentCommand(vm.curp,vm.fecha_accidente,biorritmoFisico,biorritmoEmocional,biorritmoIntelectual,biorritmoIntuicional);
            await _mediator.Send(createCommand);
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public Double CalcularBiorritmo(int diasVividos, int teoria)
        {
            var dayValue = (2 * Math.PI * (diasVividos)) / teoria;
            var sinValue = Math.Sin(dayValue);
            var roundedValue = Math.Round(sinValue, 9, MidpointRounding.ToEven);
            return roundedValue;
        }
    }
}
