using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;

namespace Patrones_de_Diseño.Strategy
{
	public interface IStrategy_Alumno
	{
		bool SosIgual(iComparable x, IAlumno y);
		bool SosMenor(iComparable x, IAlumno y);
		bool SosMayor(iComparable x, IAlumno y);
	}
	class PorDni : IStrategy_Alumno
	{
		public bool SosIgual(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetDni() == y.GetDni();
		}
		public bool SosMenor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetDni() < y.GetDni();
		}
		public bool SosMayor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetDni() > y.GetDni();
		}
	}
	class PorNombre : IStrategy_Alumno
	{
		public bool SosIgual(iComparable x, IAlumno y)
		{
			if (((IAlumno)x).GetNombre().CompareTo(y.GetNombre()) == 0)
			{
				return true;
			}
			else return false;
		}
		public bool SosMenor(iComparable x, IAlumno y)
		{
			if (((IAlumno)x).GetNombre().CompareTo(y.GetNombre()) < 0)
			{
				return true;
			}
			else return false;
		}
		public bool SosMayor(iComparable x, IAlumno y)
		{
			if (((IAlumno)x).GetNombre().CompareTo(y.GetNombre()) > 0)
			{
				return true;
			}
			else return false;
		}
	}
	class PorPromedio : IStrategy_Alumno
	{
		public bool SosIgual(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetPromedio() == y.GetPromedio();
		}
		public bool SosMenor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetPromedio() < y.GetPromedio();
		}
		public bool SosMayor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetPromedio() > y.GetPromedio();
		}
	}
	class PorLegajo : IStrategy_Alumno
	{
		public bool SosIgual(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetLegajo() == y.GetLegajo();
		}
		public bool SosMenor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetLegajo() < y.GetLegajo();
		}
		public bool SosMayor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetLegajo() > y.GetLegajo();
		}
	}
	class PorCalificacion : IStrategy_Alumno
	{
		public bool SosIgual(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetCalificacion() == y.GetCalificacion();
		}
		public bool SosMenor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetCalificacion() < y.GetCalificacion();
		}
		public bool SosMayor(iComparable x, IAlumno y)
		{
			return ((IAlumno)x).GetCalificacion() > y.GetCalificacion();
		}
	}
}
