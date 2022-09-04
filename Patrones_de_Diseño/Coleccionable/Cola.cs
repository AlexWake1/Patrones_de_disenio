using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Iterator;


namespace Patrones_de_Diseño.Coleccionable
{
    class Cola : IColeccionable, IIterable, IOrdenable
    {
        List<iComparable> ListaC;
        IOrdenEnAula1? ordeninicio = null, ordenAulaLlena = null;
        IOrdenEnAula2? ordenLlegaAlumno = null;
        public Cola()
        {
            ListaC = new List<iComparable>();
        }
        public override string ToString()
        {
            return "		***Cola*** ";
        }
        public void Agregar(iComparable x)
        {
            ListaC.Add(x);

            if (ListaC.Count == 1)
                if (ordeninicio != null)
                    ordeninicio.Ejecutar();

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar(x);

            if (ListaC.Count == 40)
                if (ordenAulaLlena != null)
                    ordenAulaLlena.Ejecutar();

        }
        public bool Contiene(iComparable x)
        {
            foreach (iComparable item in ListaC)
            {
                if (item.SosIgual(x))
                {
                    return true;
                }
            }
            return false;
        }
        public void Borrar(iComparable x)
        {
            foreach (iComparable item in ListaC)
            {
                if (item.SosIgual(x))
                {
                    ListaC.Remove(x);
                    Console.WriteLine("Se borró. ");
                    break;
                }
            }
            Console.WriteLine("No se borró. ");
        }
        public iComparable Maximo()
        {
            iComparable aux1 = ListaC[0];
            foreach (iComparable item in ListaC)
            {
                if (item.SosMayor(aux1))
                {
                    aux1 = item;
                }
            }
            return aux1;
        }
        public iComparable Minimo()
        {
            iComparable aux1 = ListaC[0];
            foreach (iComparable item in ListaC)
            {
                if (item.SosMenor(aux1))
                {
                    aux1 = item;
                }
            }
            return aux1;
        }
        public int Cuantos()
        {
            return ListaC.Count;
        }
        public void Mostrar()
        {
            foreach (iComparable item in ListaC)
            {
                Console.Write(item + " ");
            }
        }
        public IIterator CrearIterador()
        {
            return new IteradorDeListas(ListaC);
        }

        public void setOrdenInicio(IOrdenEnAula1 OrdenEnAula1)
        {
            ordeninicio = OrdenEnAula1;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 OrdenEnAula2)
        {
            ordenLlegaAlumno = OrdenEnAula2;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 OrdenEnAula1)
        {
            ordenAulaLlena = OrdenEnAula1;
        }
    }
}
