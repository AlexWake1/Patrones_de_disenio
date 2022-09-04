using Patrones_de_Diseño.Comparables;
using System.Collections.Generic;

namespace Patrones_de_Diseño.Coleccionable
{
	class ColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private Cola cola;

		public Pila GetPila { get { return pila; } }
		public Cola GetCola { get { return cola; } }

		public ColeccionMultiple(Pila p, Cola c)
		{
			pila = p;
			cola = c;
		}
		public override string ToString()
		{
			return "		***Colección Múltiple*** ";
		}
		public int Cuantos()
		{
			return GetPila.Cuantos() + GetCola.Cuantos();
		}
		public iComparable Minimo()
		{
			iComparable aux1 = pila.Minimo();
			iComparable aux2 = cola.Minimo();
			if (aux1.SosMenor(aux2))
			{
				return aux1;
			}
			else return aux2;
		}
		public iComparable Maximo()
		{
			iComparable aux1 = pila.Maximo();
			iComparable aux2 = cola.Maximo();
			if (aux1.SosMayor(aux2))
			{
				return aux1;
			}
			else return aux2;
		}
		public void Agregar(iComparable x) { }
		public bool Contiene(iComparable x)
		{
			bool aux1 = pila.Contiene(x);
			bool aux2 = cola.Contiene(x);
			if (aux1 == true || aux2 == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
