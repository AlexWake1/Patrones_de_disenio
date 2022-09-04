namespace Patrones_de_Diseño.Decorator
{
    class DecoradorLetras : DecoradorAlumno
    {
        public DecoradorLetras(IAlumno alumno) : base(alumno)
        {
        }

        public override string MostrarCalificacion()
        {
            string resultado = base.MostrarCalificacion();
            string[] letras = { "(cero)", "(uno)", "(dos)", "(tres)", "(cuatro)", "(cinco)", "(seis)", "(siete)", "(ocho)", "(nueve)", "(diez)" };
            return resultado += " " + base.GetCalificacion() + letras[base.GetCalificacion()];
        }
    }
}
