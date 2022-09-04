using Patrones_de_Diseño.Comparables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseño.Command
{
    interface IOrdenEnAula1
    {
        void Ejecutar();
    }
    interface IOrdenEnAula2
    {
        void Ejecutar(iComparable c);
    }
    interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 OrdenEnAula1);
        void setOrdenLlegaAlumno(IOrdenEnAula2 OrdenEnAula2);
        void setOrdenAulaLlena(IOrdenEnAula1 OrdenEnAula1);
    }
}