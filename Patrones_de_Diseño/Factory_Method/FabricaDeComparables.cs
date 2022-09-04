using Patrones_de_Diseño.Comparables;

namespace Patrones_de_Diseño.Factory_method
{
	public interface IFabricaDeComprarables
	{
		iComparable CrearComparableAleatorio();
		iComparable CrearComparablePorTeclado();
	}
}
