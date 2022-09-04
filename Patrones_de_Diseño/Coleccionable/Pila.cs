using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Iterator;
using System;
using System.Collections.Generic;

namespace Patrones_de_Diseño.Coleccionable
{
	class Pila : IColeccionable, IIterable, IOrdenable
	{
		List<iComparable> pilaLista;
		IOrdenEnAula1? ordenInicio = null, ordenAulaLlena = null;
		IOrdenEnAula2? ordenLlegaAlumno = null;
		public Pila()
		{
			pilaLista = new List<iComparable>();
		}
		public void Agregar(iComparable x)
		{
			pilaLista.Insert(0, x);

			if (pilaLista.Count == 1)
				if (ordenInicio != null)
					ordenInicio.Ejecutar();

			if (ordenLlegaAlumno != null)
				ordenLlegaAlumno.Ejecutar(x);

			if (pilaLista.Count == 40)
				if (ordenAulaLlena != null)
					ordenAulaLlena.Ejecutar();
		}
		public override string ToString()
		{
			return "		***Pila*** ";
		}
		public bool Contiene(iComparable x)
		{
			foreach (iComparable item in pilaLista)
			{
				if (item.SosIgual(x))
				{
					return true;
				}
			}
			return false;
		}
		public void Borrar(iComparable x)
		{
			foreach (iComparable item in pilaLista)
			{
				if (item.SosIgual(x))
				{
					pilaLista.Remove(x);
					Console.WriteLine("Se borró. ");
					break;
				}
			}
			Console.WriteLine("No se borró. ");
		}
		public iComparable Maximo()
		{
			iComparable aux1 = pilaLista[0];
			foreach (iComparable item in pilaLista)
			{
				if (item.SosMayor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public iComparable Minimo()
		{
			iComparable aux1 = pilaLista[0];
			foreach (iComparable item in pilaLista)
			{
				if (item.SosMenor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public int Cuantos()
		{
			return pilaLista.Count;
		}
		public void Mostrar()
		{
			foreach (iComparable item in pilaLista)
			{
				Console.Write(item + " ");
			}
		}

		//ITERABLE//
		public IIterator CrearIterador()
		{
			return new IteradorDeListas(pilaLista);
		}
		//ITERABLE//
		public void setOrdenInicio(IOrdenEnAula1 OrdenEnAula1)
		{
			ordenInicio = OrdenEnAula1;
		}

		public void setOrdenLlegaAlumno(IOrdenEnAula2 OrdenEnAula2)
		{
			ordenLlegaAlumno = OrdenEnAula2;
		}

		public void setOrdenAulaLlena(IOrdenEnAula1 OrdenEnAula1)
		{
			ordenAulaLlena = OrdenEnAula1;
		}
	}
}
