using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;

namespace Patrones_de_Diseño.Factory_method
{
    class FabricaVendedor : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Vendedor(GeneradorDeDatosAleatorios.NombreAleatorio(), GeneradorDeDatosAleatorios.NumeroAleatorio(10000000, 99999999), GeneradorDeDatosAleatorios.NumeroAleatorio(10000, 100000));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = LectorDeDatos.StringPorTeclado();
			Console.Write("Ingrese un DNI: ");
			int dni = LectorDeDatos.NumeroPorTeclado();
			Console.Write("Ingrese un sueldo: ");
			int sueldo = LectorDeDatos.NumeroPorTeclado();

			return new Vendedor(nombre, dni, sueldo);
		}
	}
}
