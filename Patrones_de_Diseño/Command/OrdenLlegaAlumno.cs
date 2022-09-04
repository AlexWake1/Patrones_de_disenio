using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;

namespace Patrones_de_Diseño.Command
{
    class OrdenLlegaAlumno : IOrdenEnAula2
    {
        Aula aula;
        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void Ejecutar(iComparable c)
        {
            aula.NuevoAlumno((IAlumno)c);
        }
    }
}
