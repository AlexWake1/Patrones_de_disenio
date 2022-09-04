using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Factory_method;

namespace Patrones_de_Diseño.Proxy
{
    internal class ProxyAlumnoMuyEstudioso : ProxyAlumno
    {
        public ProxyAlumnoMuyEstudioso(string nombre) : base(nombre)
        {
        }
        public override string ToString()
        {
            return "Nombre:" + nombre;
        }
        public override int ResponderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                Console.WriteLine("Se creó el alumno muy estudioso");
                alumnoReal = (AlumnoMuyEstudioso)Fabrica.CrearComparable(8);
            }
            return alumnoReal.ResponderPregunta(pregunta);
        }
    }
}
