using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Decorator
{
    public interface IAlumno
    {
        bool SosIgual(iComparable x);
        bool SosMenor(iComparable x);
        bool SosMayor(iComparable x);
        void CambiarEstrategia(IStrategy_Alumno x);
        int ResponderPregunta(int pregunta);
        string MostrarCalificacion();


        int GetLegajo();
        string GetNombre();
        int GetDni();
        int GetPromedio();
        int GetCalificacion();
        void SetCalificacion(int ncalificacion);
    }
}
