namespace Patrones_de_Diseño.Comparables
{
    class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio) : base(nombre, dni, legajo, promedio)
        {

        }
        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
