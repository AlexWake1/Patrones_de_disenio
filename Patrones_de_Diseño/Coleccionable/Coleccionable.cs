using Patrones_de_Diseño.Comparables;

namespace Patrones_de_Diseño.Coleccionable
{
	public interface IColeccionable
	{
		int Cuantos();
        iComparable Minimo();
		iComparable Maximo();
		void Agregar(iComparable x);
		bool Contiene(iComparable x);
	}
}
