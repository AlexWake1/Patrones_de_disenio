using System;

namespace Patrones_de_Diseño
{
	class LectorDeDatos
	{
		public LectorDeDatos()
		{

		}

		public int NumeroPorTeclado()
		{
			Console.Write("Escriba números: ");
			return int.Parse(Console.ReadLine());
		}
		public string StringPorTeclado()
		{
			Console.Write("Escriba un string: ");
			return Console.ReadLine();
		}

	}
}
