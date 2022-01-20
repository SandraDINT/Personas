
using Personas.VistasXAML;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    public class NavigationService
    {
        private static readonly UserControl personas =
            new ListadoPersonasUserControl();

        public NavigationService()
        {
        }

        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }
        public UserControl ObtenerListadoPersonas()
        {
            return personas;
        }
    }
}
