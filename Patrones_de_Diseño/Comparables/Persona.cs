namespace Patrones_de_Diseño.Comparables
{
    public class Persona : iComparable
    {
        private int dni;
        private string nombre;

        public Persona(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Persona(){}
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        override public string ToString()
        {
            return "Nombre: " + this.Nombre.ToString() + ", Dni: " + Dni.ToString();
        }
        public bool SosIgual(iComparable x)
        {
            return this.Dni == ((Persona)x).Dni;
        }
        public bool SosMenor(iComparable x)
        {
            return this.Dni < ((Persona)x).Dni;
        }
        public bool SosMayor(iComparable x)
        {
            return this.Dni > ((Persona)x).Dni;
        }
    }
}
