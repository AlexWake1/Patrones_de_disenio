using Patrones_de_Diseño.Proxy;
using Patrones_de_Diseño.Comparables;
using System;

namespace Patrones_de_Diseño.Factory_method
{
    class FabricaProxyAlumno : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new ProxyAlumno(aleatorio.NombreAleatorio());
        }
        public override iComparable CrearComparablePorTeclado()
        {
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();
            return new ProxyAlumno(nombre);
        }
    }
}
