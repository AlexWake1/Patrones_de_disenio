using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;
using System;
namespace Patrones_de_Diseño.Factory_method
{
    class FabricaPersona : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new Persona(GeneradorDeDatosAleatorios.NumeroAleatorio(10000000, 99999999), GeneradorDeDatosAleatorios.NombreAleatorio());
        }
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = LectorDeDatos.StringPorTeclado();
			Console.Write("Ingrese un DNI: ");
			int dni = LectorDeDatos.NumeroPorTeclado();

			return new Persona(dni, nombre);
		}
	}
}
