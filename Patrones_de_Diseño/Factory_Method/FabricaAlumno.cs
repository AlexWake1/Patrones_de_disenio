using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;
using System;
namespace Patrones_de_Diseño.Factory_method
{
    class FabricaAlumno : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new Alumno(GeneradorDeDatosAleatorios.NombreAleatorio(), GeneradorDeDatosAleatorios.NumeroAleatorio(10000000, 99999999), GeneradorDeDatosAleatorios.NumeroAleatorio(10000, 99999), GeneradorDeDatosAleatorios.NumeroAleatorio(100, 999));
		}
		public override iComparable CrearComparablePorTeclado()
        {
			Console.Write("Ingrese un nombre: ");
			string nombre = LectorDeDatos.StringPorTeclado();
			Console.Write("Ingrese un dni: ");
			int dni = LectorDeDatos.NumeroPorTeclado();
			Console.Write("Ingrese un legajo: ");
			int legajo = LectorDeDatos.NumeroPorTeclado();
			Console.Write("Ingrese un promedio: ");
			int promedio = LectorDeDatos.NumeroPorTeclado();

			return new Alumno(nombre, dni, legajo, promedio);
		}
    }
	class FabricaAlumnoMuyEstudioso : Fabrica
	{
        public override iComparable CrearComparable()
		{
			return new AlumnoMuyEstudioso(GeneradorDeDatosAleatorios.NombreAleatorio(), GeneradorDeDatosAleatorios.NumeroAleatorio(10000000, 99999999), GeneradorDeDatosAleatorios.NumeroAleatorio(10000, 99999), GeneradorDeDatosAleatorios.NumeroAleatorio(100, 999));
		}
		public override iComparable CrearComparablePorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = LectorDeDatos.StringPorTeclado();
			Console.Write("Ingrese un DNI: ");
			int dni = LectorDeDatos.NumeroPorTeclado();
			Console.Write("Ingrese un legajo: ");
			int legajo = LectorDeDatos.NumeroPorTeclado();
			Console.Write("Ingrese un promedio: ");
			int promedio = LectorDeDatos.NumeroPorTeclado();

			return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
		}
	}
}
