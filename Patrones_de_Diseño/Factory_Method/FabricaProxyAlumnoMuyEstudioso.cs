using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Proxy;

namespace Patrones_de_Diseño.Factory_method
{
    class FabricaProxyAlumnoMuyEstudioso : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new ProxyAlumnoMuyEstudioso(aleatorio.NombreAleatorio());
        }
        public override iComparable CrearComparablePorTeclado()
        {
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            return new ProxyAlumnoMuyEstudioso(nombre);
        }
    }
}
