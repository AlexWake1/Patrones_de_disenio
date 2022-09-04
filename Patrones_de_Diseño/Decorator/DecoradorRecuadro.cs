namespace Patrones_de_Diseño.Decorator
{
    class DecoradorRecuadro : DecoradorAlumno
    {
        public DecoradorRecuadro(IAlumno alumno) : base(alumno)
        {
        }

        public override string MostrarCalificacion()
        {

            string asteriscos = "**";
            string resultado = base.MostrarCalificacion();

            foreach (char item in base.MostrarCalificacion())
            {
                asteriscos += "*";
            }

            return resultado = asteriscos+'\n' + resultado.Insert(0, "*").Insert(resultado.Length+1,"*") + '\n' + asteriscos;
        }
    }
}
