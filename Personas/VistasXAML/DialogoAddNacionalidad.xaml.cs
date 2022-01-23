using Personas.VistasMvvm;
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

namespace Personas.VistasXAML
{
    /// <summary>
    /// Lógica de interacción para DialogoAddNacionalidad.xaml
    /// </summary>
    public partial class DialogoAddNacionalidad : Window
    {
        private DialogoAddNacionalidadMvvm vm;
        public DialogoAddNacionalidad()
        {
            InitializeComponent();
            vm = new DialogoAddNacionalidadMvvm();
            this.DataContext = vm;
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Aceptar();
            DialogResult = true;
        }
    }
}
