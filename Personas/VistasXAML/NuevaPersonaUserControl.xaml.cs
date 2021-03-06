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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas.VistasXAML
{
    /// <summary>
    /// Lógica de interacción para NuevaPersonaUserControl.xaml
    /// </summary>
    public partial class NuevaPersonaUserControl : UserControl
    {
        private readonly NuevaPersonaMvvm vm;
        public NuevaPersonaUserControl()
        {
            InitializeComponent();
            vm = new NuevaPersonaMvvm();
            this.DataContext = vm;
        }
    }
}
