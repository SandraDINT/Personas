using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.VistasMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Personas
{
    class NuevaPersonaMvvm : ObservableObject
    {
        private readonly NavigationService navigation;
        public RelayCommand AbrirDialogoCommand { get; }

        private DialogoAddNacionalidadMvvm dialogo;

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
            AbrirDialogoCommand = new RelayCommand(AbrirAddNacionalidad);
            _nuevaPersona = new Persona();
            Nacionalidades = new ObservableCollection<string>() { "Española", "Guineana", "China", "Japonesa", "Marfileña", "Francesa" };
            dialogo = new DialogoAddNacionalidadMvvm(_nacionalidades);
        }
        private void AbrirAddNacionalidad()
        {
            navigation.AddNacionalidad();
        }
    }
}