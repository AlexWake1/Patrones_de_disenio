using Patrones_de_Diseño.Comparables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Patrones_de_Diseño.Iterator
{
	public interface IIterator
	{
		void Primero();
		void Siguiente();
		bool Fin();
		iComparable Actual();
	}
	public interface IIterable
	{
		IIterator CrearIterador();
	}

	class IteradorDeListas : IIterator
	{
		private int paginaActual;
		private List<iComparable> paginas;
		public IteradorDeListas(List<iComparable> documento)
		{
			paginas = documento;
		}
		public void Primero()
		{
			paginaActual = 0;
		}
		public void Siguiente()
		{
			paginaActual++;
		}
		public bool Fin()
		{
			return paginaActual >= paginas.Count();
		}
		public iComparable Actual()
		{
			return paginas[paginaActual];
		}
	}

    class IteradorDePilas : IIterator
    {
        private int paginaActual;
        private List<iComparable> paginas;
        public IteradorDePilas(List<iComparable> documento)
        {
            paginas = documento;
        }
        public void Primero()
        {
            paginaActual = paginas.Count()-1;
        }
        public void Siguiente()
        {
            paginaActual--;
        }
        public bool Fin()
        {
            return paginaActual == 0;
        }
        public iComparable Actual()
        {
            return paginas[paginaActual];
        }
    }

    public static class Impresora
	{
		public static void Imprimir(IIterable documento)
		{
            IIterator? iterador;

            Console.WriteLine(documento);

			iterador = documento.CrearIterador();

            iterador.Primero();
			while (!iterador.Fin())
			{
				iComparable aux1 = iterador.Actual();

				Console.WriteLine(aux1);

				iterador.Siguiente();
			}
		}
	}
}
