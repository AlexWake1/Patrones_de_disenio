using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrones_de_Diseño.Decorator
{
    class DecoradorPromocion : DecoradorAlumno
    {
        public DecoradorPromocion(IAlumno alumno) : base(alumno)
        {
        }

        public override string MostrarCalificacion()
        {
            string resultado = base.MostrarCalificacion();
            if (GetCalificacion()>=7)
            {
                return resultado += " --PROMOCION--";
            }
            if (GetCalificacion()>=4 && GetCalificacion() <= 6)
            {
                return resultado += " --APROBADO--";
            }
            else
            {
                return resultado += " --DESAPROBADO--";
            }
        }
    }
}
