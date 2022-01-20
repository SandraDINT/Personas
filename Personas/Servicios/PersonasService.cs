using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class PersonasService
    {
        public ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> personas = 
                new ObservableCollection<Persona>();
            personas.Add(new Persona("Sandra", 24, "ESPAÑOLA"));
            personas.Add(new Persona("Vicente", 51, "ESPAÑOLA"));
            personas.Add(new Persona("Alejandro", 19, "ESPAÑOLA"));
            personas.Add(new Persona("Prince", 35, "Marfileño"));
            personas.Add(new Persona("Alan", 18, "Francés"));
            return personas;
        }
    }
}
