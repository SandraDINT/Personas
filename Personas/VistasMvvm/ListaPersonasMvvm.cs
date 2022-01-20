using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.VistasMvvm
{
    class ListaPersonasMvvm : ObservableObject
    {
        private ObservableCollection<Persona> personas;
        private readonly PersonasService personasService;
        public ListaPersonasMvvm()
        {
            personasService = new PersonasService();
            personas = personasService.GetPersonas();
        }

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }
    }
}
