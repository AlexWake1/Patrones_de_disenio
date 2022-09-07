using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Iterator;
using System.Collections.Generic;

namespace Patrones_de_Diseño.Coleccionable
{
	class Conjunto : IColeccionable, IIterable , IOrdenable
	{
		private List<iComparable> lista;
		IOrdenEnAula1? ordeninicio = null, ordenAulaLlena = null;
		IOrdenEnAula2? ordenLlegaAlumno = null;
		public Conjunto()
		{
			lista = new List<iComparable>();
		}
		public override string ToString()
		{
			return "		***Conjunto*** ";
		}
		public void Agregar(iComparable x)
		{

            if (!this.Contiene(x))
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
		public int Cuantos()
		{
			return lista.Count;
		}
		public iComparable Minimo()
		{
			iComparable aux1 = lista[0];
			foreach (iComparable item in lista)
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
			foreach (iComparable item in lista)
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
			foreach (iComparable item in lista)
			{
				if (item.SosIgual(x))
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
