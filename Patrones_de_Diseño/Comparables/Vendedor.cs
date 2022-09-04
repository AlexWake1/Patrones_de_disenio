using Patrones_de_Diseño.Observer;

namespace Patrones_de_Diseño.Comparables
{
	public class Vendedor : Persona, iComparable, IObservado
	{
		protected int sueldoBasico = 0;
		protected double bonus;
		protected List<IObservador> observadores;
		protected int ultimaventa = 0;

		public Vendedor(string nombre, int dni, int sueldo) : base(dni, nombre)
		{
			sueldo = sueldoBasico;
			bonus = 1;
			observadores = new List<IObservador>();
		}
		public override string ToString()
		{
			return "Nombre: " + Nombre + ", Ultima venta: " + GetUltimaventa.ToString() + " DNI: " + Dni;
		}
		public int GetUltimaventa
		{
			get { return ultimaventa; }
			set { ultimaventa = value; }
		}

		public virtual void Venta(int monto)
		{
			Console.WriteLine("El monto recibido es :" + monto + ".");
			GetUltimaventa = monto;
			this.Notificar();
		}

		public void AumentaBonus()
		{
			bonus += 0.1;
		}

		public void AgregarObservador(IObservador observador)
		{
			this.observadores.Add(observador);
		}

		public void QuitarObservador(IObservador observador)
		{
			foreach (IObservador item in observadores)
			{
				if (item.Equals(observador))
				{
					observadores.Remove(item);
				}
			}
		}
		public void Notificar()
		{
			foreach (IObservador item in observadores)
			{
				item.Actualizar(this);
			}
		}
	}
}
