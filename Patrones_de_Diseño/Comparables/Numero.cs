using Patrones_de_Diseño.Factory_method;
using System;

namespace Patrones_de_Diseño.Comparables
{
	class Numero : iComparable
	{
		private int valor;
		public Numero(int x)
		{
			valor = x;
		}
		public int GetValor
		{
			get { return valor; }
		}
		public override string ToString()
		{
			return "Numero: "  + this.GetValor.ToString();
		}
		//----------*COMPARABLE*----------//
		public bool SosIgual(iComparable x)
		{
			return this.valor == ((Numero)x).GetValor;
		}
		public bool SosMenor(iComparable x)
		{
			return this.valor < ((Numero)x).GetValor;
		}
		public bool SosMayor(iComparable x)
		{
			return this.valor > ((Numero)x).GetValor;
		}
		//----------*COMPARABLE*----------//


		//----------*FABRICA DE COMPARABLES*----------//
		public iComparable CrearAleatorio()
		{
			Random aux1 = new Random();
			return new Numero(aux1.Next(0, 100));
		}
		public iComparable CrearPorTeclado()
		{
			Console.WriteLine("Ingrese el numero que desea crear: ");
			return new Numero(int.Parse(Console.ReadLine()));
		}
		//----------*FABRICA DE COMPARABLES*----------//
	}
}
