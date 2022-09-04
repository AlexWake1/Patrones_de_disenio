namespace Patrones_de_Diseño.Comparables
{
	class ClaveValor : iComparable
	{
		private int clave;
		private iComparable valor;
		public ClaveValor(int clave, iComparable valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
		public override string ToString()
		{
			return "Clave: " + Clave.ToString() + ", Valor: " + Valor;
		}
		public int Clave
		{
			get { return clave; }
			set { clave = value; }
		}
		public iComparable Valor
		{
			get { return valor; }
			set { valor = value; }
		}
		public bool SosIgual(iComparable x)
		{
			return this.Clave == ((ClaveValor)x).Clave;
		}
		public bool SosMenor(iComparable x)
		{
			return this.Clave < ((ClaveValor)x).Clave;
		}
		public bool SosMayor(iComparable x)
		{
			return this.Clave > ((ClaveValor)x).Clave;
		}
	}
}
