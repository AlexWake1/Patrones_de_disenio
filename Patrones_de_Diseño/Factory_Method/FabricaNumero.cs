using Patrones_de_Diseño.Comparables;
using System;
namespace Patrones_de_Diseño.Factory_method
{
	class FabricaNumero : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Numero(aleatorio.NumeroAleatorio(0, 20));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Numero: ");
			int numero = int.Parse(Console.ReadLine());
			return new Numero(numero);
		}
	}
}
