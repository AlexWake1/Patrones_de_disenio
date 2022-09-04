using Patrones_de_Diseño.Comparables;
using System;
namespace Patrones_de_Diseño.Factory_method
{
    class FabricaPersona : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new Persona(aleatorio.NumeroAleatorio(10000000, 99999999), aleatorio.NombreAleatorio());
        }
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese un DNI: ");
			int dni = int.Parse(Console.ReadLine());

			return new Persona(dni, nombre);
		}
	}
}
