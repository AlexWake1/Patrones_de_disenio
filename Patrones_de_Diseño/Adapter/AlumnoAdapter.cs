using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;

namespace Patrones_de_Diseño.Adapter
{
    class AlumnoAdapter : Student
    {
        IAlumno alumno;
        public AlumnoAdapter(Alumno alumno)
        {
            this.alumno = alumno;
        }

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public IAlumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }

        string Student.getName()
        {
            return alumno.GetNombre();
        }

        bool Student.equals(Student student)
        {
            return alumno.SosIgual((iComparable)((AlumnoAdapter)student).Alumno);
        }

        bool Student.greaterThan(Student student)
        {
            return alumno.SosMayor((iComparable)((AlumnoAdapter)student).Alumno);
        }

        bool Student.lessThan(Student student)
        {
            return alumno.SosMenor((iComparable)((AlumnoAdapter)student).Alumno);
        }

        void Student.setScore(int score)
        {
            alumno.SetCalificacion(score);
        }

        string Student.showResult()
        {
            return alumno.MostrarCalificacion();
        }

        int Student.yourAnswerIs(int question)
        {
            return alumno.ResponderPregunta(question);
        }
    }
}
