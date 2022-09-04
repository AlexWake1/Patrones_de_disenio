using Patrones_de_Diseño.Observer;
using System;

namespace Patrones_de_Diseño.Comparables
{
	class VendedorPauperrimo : Vendedor, IObservado
	{
		
		private int accion=0;//=1 robando,= 2 descansando,=3 molestando
		public VendedorPauperrimo(string nombre, int dni, int sueldo) : base(nombre, dni, sueldo)
		{
		}
		public int Accion { get { return accion; } set { accion = value; } }
		public void Robar()
		{
			accion=1;
			Console.WriteLine("El/la vendedor/a: " + this.Nombre + ", está robando.");
		}
		public void Descansar()
		{
			accion = 2;
			Console.WriteLine("El/la vendedor/a: " + this.Nombre + ", está descansando.");
		}
		public void Molestarcompañeros()
		{
			accion = 3;
			Console.WriteLine("El/la vendedor/a: " + this.Nombre + ", está molestando a sus compañeros.");
		}

		public override void Venta(int monto)
		{
			Console.WriteLine(this.Nombre + " realizó una venta de :" + monto + ".");
			GetUltimaventa = monto;

			if (monto <= 500)
			{
				Robar();
			}
			if (monto >= 4000)
			{
				Descansar();
			}
			if (monto > 500 && monto < 4000)
			{
				Molestarcompañeros();
			}
			this.Notificar();
		}
	}
}
