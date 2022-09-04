using Patrones_de_Diseño.Comparables;

namespace Patrones_de_Diseño.Factory_method
{
	class FabricaVendedor : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Vendedor(aleatorio.NombreAleatorio(), aleatorio.NumeroAleatorio(10000000, 99999999), aleatorio.NumeroAleatorio(10000, 100000));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese un DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese un sueldo: ");
			int sueldo = int.Parse(Console.ReadLine());

			return new Vendedor(nombre, dni, sueldo);
		}
	}
}
