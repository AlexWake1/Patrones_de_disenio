using Patrones_de_Diseño.Comparables;
using System;
namespace Patrones_de_Diseño.Factory_method
{
	class FabricaClaveValor : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new ClaveValor(aleatorio.NumeroAleatorio(0, 100), Fabrica.CrearComparable(aleatorio.NumeroAleatorio(1, 10)));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese la clave: ");
			int clave = int.Parse(Console.ReadLine());

			Console.Write("Ingrese un valor: ");
			int valor = int.Parse(Console.ReadLine());

			return new ClaveValor(clave,CrearComparablePorTeclado(valor));
		}
	}
}
