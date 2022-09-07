using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;
using System;
namespace Patrones_de_Diseño.Factory_method
{
    class FabricaNumero : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Numero(GeneradorDeDatosAleatorios.NumeroAleatorio(0, 20));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Numero: ");
			int numero = LectorDeDatos.NumeroPorTeclado();
			return new Numero(numero);
		}
	}
}
