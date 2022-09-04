using Patrones_de_Diseño.Comparables;
using System;
namespace Patrones_de_Diseño.Factory_method
{
	class FabricaAlumno : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Alumno(aleatorio.NombreAleatorio(), aleatorio.NumeroAleatorio(10000000, 99999999), aleatorio.NumeroAleatorio(10000, 99999), aleatorio.NumeroAleatorio(100, 999));
		}
		public override iComparable CrearComparablePorTeclado()
        {
			Console.Write("Ingrese un nombre: ");
			string nombre = Console.ReadLine();
			Console.WriteLine("Ingrese un dni: ");
			int dni = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese un legajo: ");
			int legajo = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese un promedio: ");
			int promedio = int.Parse(Console.ReadLine());

			return new Alumno(nombre, dni, legajo, promedio);
		}
    }
	class FabricaAlumnoMuyEstudioso : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new AlumnoMuyEstudioso(aleatorio.NombreAleatorio(), aleatorio.NumeroAleatorio(10000000, 99999999), aleatorio.NumeroAleatorio(10000, 99999), aleatorio.NumeroAleatorio(100, 999));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = Console.ReadLine();
			Console.Write("Ingrese un DNI: ");
			int dni = int.Parse(Console.ReadLine());
			Console.Write("Ingrese un legajo: ");
			int legajo = int.Parse(Console.ReadLine());
			Console.Write("Ingrese un promedio: ");
			int promedio = int.Parse(Console.ReadLine());

			return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
		}
	}
}
