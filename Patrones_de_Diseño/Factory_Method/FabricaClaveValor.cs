using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;
using System;
namespace Patrones_de_Diseño.Factory_method
{
    class FabricaClaveValor : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new ClaveValor(GeneradorDeDatosAleatorios.NumeroAleatorio(0, 20), Fabrica.CrearComparable(3));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese la clave: ");
			int clave = LectorDeDatos.NumeroPorTeclado();
			Metodos.Opciones_Fabrica();
			Console.Write("Ingrese un valor: ");
			int valor = LectorDeDatos.NumeroPorTeclado();

			return new ClaveValor(clave,CrearComparablePorTeclado(valor));
		}
	}
}
