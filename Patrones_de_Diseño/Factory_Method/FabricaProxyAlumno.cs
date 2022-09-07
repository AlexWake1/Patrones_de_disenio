using Patrones_de_Diseño.Proxy;
using Patrones_de_Diseño.Comparables;
using System;
using Patrones_de_Diseño.Metodos_Auxiliares;

namespace Patrones_de_Diseño.Factory_method
{
    class FabricaProxyAlumno : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new ProxyAlumno(GeneradorDeDatosAleatorios.NombreAleatorio());
        }
        public override iComparable CrearComparablePorTeclado()
        {
            Console.Write("Ingrese un nombre: ");
            string nombre = LectorDeDatos.StringPorTeclado();
            return new ProxyAlumno(nombre);
        }
    }
}
