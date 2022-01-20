using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Personas.VistasMvvm
{
    class NuevaPersonaMvvm : ObservableObject
    {
        private readonly NavigationService navigation;

        private Persona _nuevaPersona;
        public Persona NuevaPersona
        {
            get { return _nuevaPersona; }
            set { SetProperty(ref _nuevaPersona, value); }
        }

        private ObservableCollection<string> _nacionalidades;
        public ObservableCollection<string> Nacionalidades
        {
            get { return _nacionalidades; }
            set { SetProperty(ref _nacionalidades, value); }
        }

        public NuevaPersonaMvvm()
        {
            navigation = new NavigationService();
            NuevaPersona = new Persona();
        }
    }
}
