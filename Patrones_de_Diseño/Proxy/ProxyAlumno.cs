using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;
using Patrones_de_Diseño.Factory_method;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Proxy
{
    class ProxyAlumno : IAlumno, iComparable
    {
        protected string nombre;
        protected IAlumno alumnoReal;

        public ProxyAlumno(string nombre)
        {
            this.nombre = nombre;
            alumnoReal = null;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre;
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            if (alumnoReal == null)
            {
                Console.WriteLine("Se creó el alumno");
                alumnoReal = (Alumno)Fabrica.CrearComparable(3);
            }
            return alumnoReal.ResponderPregunta(pregunta);
        }
        public string GetNombre()
        {
            return this.nombre;
        }

        public void CambiarEstrategia(IStrategy_Alumno x)
        {
            alumnoReal.CambiarEstrategia(x);
        }

        public int GetCalificacion()
        {
            return alumnoReal.GetCalificacion();
        }

        public int GetDni()
        {
            return alumnoReal.GetDni();
        }

        public int GetLegajo()
        {
            return alumnoReal.GetLegajo();
        }

        public int GetPromedio()
        {
            return alumnoReal.GetPromedio();
        }

        public string MostrarCalificacion()
        {
            return alumnoReal.MostrarCalificacion();
        }

        public void SetCalificacion(int ncalificacion)
        {
            alumnoReal.SetCalificacion(ncalificacion);
        }

        public bool SosIgual(iComparable x)
        {
            return alumnoReal.SosIgual(x);
        }

        public bool SosMayor(iComparable x)
        {
            return alumnoReal.SosMayor(x);
        }

        public bool SosMenor(iComparable x)
        {
            return alumnoReal.SosMenor(x);
        }
    }
}
