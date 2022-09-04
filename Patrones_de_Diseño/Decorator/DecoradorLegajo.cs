namespace Patrones_de_Diseño.Decorator
{
    class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(IAlumno alumno) : base(alumno)
        {
        }

        public override string MostrarCalificacion()
        {
            string resultado = base.MostrarCalificacion();

            return resultado += " (" +GetLegajo()+")";
        }
    }
}
