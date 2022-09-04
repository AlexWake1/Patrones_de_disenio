using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Decorator
{
    abstract class DecoradorAlumno : IAlumno , iComparable
    {
        IAlumno adicional;
        
        public DecoradorAlumno(IAlumno alumno)
        {
            this.adicional = alumno;
        }

        public IAlumno Adicional
        {
            get { return adicional; }
            set { adicional = value; }
        }

        public int GetLegajo()
        {
            return adicional.GetLegajo();
        }

        public virtual string MostrarCalificacion()
        {
            return adicional.MostrarCalificacion();
        }

        public void CambiarEstrategia(IStrategy_Alumno x)
        {
            this.adicional.CambiarEstrategia(x);
        }

        public int ResponderPregunta(int pregunta)
        {
            return adicional.ResponderPregunta(pregunta);
        }

        public bool SosIgual(iComparable x)
        {
            return adicional.SosIgual(x);
        }

        public bool SosMayor(iComparable x)
        {
            return adicional.SosMayor(x);
        }

        public bool SosMenor(iComparable x)
        {
            return adicional.SosMenor(x);
        }

        public string GetNombre()
        {
            return adicional.GetNombre();
        }

        public void SetCalificacion(int ncalificacion)
        {
            adicional.SetCalificacion(ncalificacion);
        }

        public int GetDni()
        {
           return adicional.GetDni();
        }

        public int GetPromedio()
        {
           return adicional.GetPromedio();
        }

        public int GetCalificacion()
        {
            return adicional.GetCalificacion();
        }
    }
}
