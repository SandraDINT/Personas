using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.VistasMvvm
{
    class DialogoAddNacionalidadMvvm : ObservableObject
    {
        NavigationService navigation;

        public DialogoAddNacionalidadMvvm()
        {

        }

        public DialogoAddNacionalidadMvvm(ObservableCollection<string> nacionalidades)
        {
            navigation = new NavigationService();
        }
        public void Aceptar()
        {
            
        }
    }
}
