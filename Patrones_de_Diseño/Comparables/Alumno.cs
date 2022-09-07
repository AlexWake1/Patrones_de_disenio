using Patrones_de_Diseño.Decorator;
using Patrones_de_Diseño.Metodos_Auxiliares;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Comparables
{
    public class Alumno : Persona, iComparable, IAlumno
    {
        private int legajo;
        private int promedio;
        private IStrategy_Alumno estrategia;
        private int calificacion = 0;
        public Alumno(string nombre, int dni, int legajo, int promedio) : base(dni, nombre)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            estrategia = new PorPromedio();
        }
        public Alumno(string nombre)
        {
            estrategia = new PorPromedio();
            this.Nombre = nombre;
        }
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public int Promedio
        {
            get { return promedio; }
            set { promedio = value; }
        }
        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        override public string ToString()
        {
            return "Nombre: " + this.Nombre.ToString() + ", Dni: " + Dni.ToString() + ", Legajo: " + Legajo.ToString() + ", Promedio: " + Promedio.ToString();
        }
        //----------*COMPARABLE*----------//
        public new bool SosIgual(iComparable x)
        {
            return this.estrategia.SosIgual(this, (IAlumno)x);
        }
        public new bool SosMenor(iComparable x)
        {
            return this.estrategia.SosMenor(this, (IAlumno)x);
        }
        public new bool SosMayor(iComparable x)
        {
            return this.estrategia.SosMayor(this, (IAlumno)x);
        }
        //----------*COMPARABLE*----------//

        //----------*STRATEGY*----------//
        public void CambiarEstrategia(IStrategy_Alumno x)
        {
            estrategia = x;
        }
        //----------*STRATEGY*----------//

        //----------*ADAPTER*----------//
        public virtual int ResponderPregunta(int pregunta)
        {
            return GeneradorDeDatosAleatorios.NumeroAleatorio(1, 3);
        }

        public string MostrarCalificacion()
        {
            return Nombre + ' ' + Calificacion.ToString();
        }
        public int GetLegajo()
        {
            return Legajo;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void SetCalificacion(int ncalificacion)
        {
            this.Calificacion = ncalificacion;
        }
        public int GetDni()
        {
            return Dni;
        }
        public int GetPromedio()
        {
            return Promedio;
        }
        public int GetCalificacion()
        {
            return Calificacion;
        }
        //----------*ADAPTER*----------//
    }
}
