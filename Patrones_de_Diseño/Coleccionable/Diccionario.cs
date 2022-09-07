using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Iterator;
using System.Collections.Generic;
using System.Linq;

namespace Patrones_de_Diseño.Coleccionable
{
	class Diccionario : IColeccionable, IIterable, IOrdenable
	{
		private List<iComparable> lista;
		IOrdenEnAula1? ordeninicio = null, ordenAulaLlena = null;
		IOrdenEnAula2? ordenLlegaAlumno = null;
		public Diccionario()
		{
			lista = new List<iComparable>();
		}
		public override string ToString()
		{
			return "		***Diccionario*** ";
		}
		public void Agregar(iComparable x)
		{
			bool aux1 = false;
			foreach (ClaveValor item in lista)
			{
				if (item.Clave==((ClaveValor)x).Clave)
				{
                    item.Valor = ((ClaveValor)x).Valor;
                    //Console.WriteLine("El elemento ha sido modificado en el conjunto");
                    aux1 = true;
                    break;
                }
			}

			if (aux1 == false)
			{
				if (x.GetType() == typeof(ClaveValor))
				{
					lista.Add(x);

					if (lista.Count == 1)
						if (ordeninicio != null)
							ordeninicio.Ejecutar();

					if (ordenLlegaAlumno != null)
						ordenLlegaAlumno.Ejecutar(x);

					if (lista.Count == 40)
						if (ordenAulaLlena != null)
							ordenAulaLlena.Ejecutar();
				}
			}
		}
		public iComparable ValorDe(int indice)
		{
			foreach (ClaveValor item in lista)
			{
				if (item.Clave == indice)
				{
					return item.Valor;
				}
			}
			return null;
		}
		public int Cuantos()
		{
			return lista.Count();
		}
		public iComparable Minimo()
		{
			iComparable aux1 = lista[0];
			foreach (ClaveValor item in lista)
			{
				if (item.SosMenor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public iComparable Maximo()
		{
			iComparable aux1 = lista[0];
			foreach (ClaveValor item in lista)
			{
				if (item.SosMayor(aux1))
				{
					aux1 = item;
				}
			}
			return aux1;
		}
		public bool Contiene(iComparable x)
		{
			foreach (ClaveValor item in lista)
			{
				if (x.Equals(item.Valor))
				{
					return true;
				}
			}
			return false;
		}
		public IIterator CrearIterador()
		{
			return new IteradorDeListas(lista);
		}

		public void setOrdenInicio(IOrdenEnAula1 OrdenEnAula1)
		{
			ordeninicio = OrdenEnAula1;
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
