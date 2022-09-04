namespace Patrones_de_Diseño.Comparables
{
	public interface iComparable
	{
		bool SosIgual(iComparable x);
		bool SosMenor(iComparable x);
		bool SosMayor(iComparable x);
	}
}
