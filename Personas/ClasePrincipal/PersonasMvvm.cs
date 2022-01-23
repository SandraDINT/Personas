using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vistaModeloPrincipal
{
    class PersonasMvvm : ObservableObject
    {
        public RelayCommand AbrirListadoPersonasCommand { get; }
        public RelayCommand AbrirNuevaPersonaCommand { get; }

        private readonly NavigationService navigation;

        private UserControl _contenidoVentana;
        public UserControl ContenidoVentana
        {
            get { return _contenidoVentana; }
            set { SetProperty(ref _contenidoVentana, value); }
        }

        public PersonasMvvm()
        {
            navigation = new NavigationService();
            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);

        }
        private void AbrirListadoPersonas()
        {
            ContenidoVentana = navigation.ObtenerListadoPersonas();
        }
        private void AbrirNuevaPersona()
        {
            ContenidoVentana = navigation.ObtenerNuevaPersona();
        }
       
        
    }
}
