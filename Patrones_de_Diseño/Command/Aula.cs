using Patrones_de_Diseño.Adapter;
using Patrones_de_Diseño.Decorator;
using System;

namespace Patrones_de_Diseño.Command
{
    class Aula
    {
        Teacher profe;

        public Aula() { }

        public void Comenzar()
        {
            Console.WriteLine("La Clase va a Comenzar");
            profe = new Teacher();
        }

        public void NuevoAlumno(IAlumno alumno)
        {
            profe.goToClass(new AlumnoAdapter(alumno));
        }

        public void ClaseLista()
        {
            profe.teachingAClass();
        }
    }
}
