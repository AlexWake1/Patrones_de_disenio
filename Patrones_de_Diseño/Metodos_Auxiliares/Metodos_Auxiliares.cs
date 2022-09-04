using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Factory_method;
using Patrones_de_Diseño.Iterator;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Metodos_Auxiliares
{
    public class Metodos_Auxiliares
    {
        public void Llenar(IColeccionable lista, int OPCION)
        {
            iComparable aux1;
            for (int i = 0; i < 20; i++)
            {
                aux1 = Fabrica.CrearComparable(OPCION);
                lista.Agregar(aux1);
            }
        }
        public void Informar(IColeccionable lista, int numdecomparable)
        {
            Console.WriteLine();
            Console.WriteLine(lista);
            Console.WriteLine("Cantidad de elementos en el coleccionable: " + lista.Cuantos());
            Console.WriteLine("Menor elemento en el coleccionable... " + lista.Minimo());
            Console.WriteLine("Mayor elemento en el coleccionable... " + lista.Maximo());
            Console.WriteLine("Buscar en el IColeccionable el siguiente iComparable creado por teclado...");
            iComparable aux1 = Fabrica.CrearComparablePorTeclado(numdecomparable);
            Console.WriteLine("Elemento a buscar: " + aux1);
            if (lista.Contiene(aux1))
            {
                Console.WriteLine("El elemento existe en el coleccionable.");
            }
            else
            {
                Console.WriteLine("El elemento no existe en el coleccionable");
            }
            Console.WriteLine();
        }
        //public void ImprimirElementos(IIterable x)
        //{
        //    var impresora = new Impresora();

        //    impresora.Imprimir(x);
        //}
        public void CambiarEstrategia(IColeccionable documento, IStrategy_Alumno estrategia)
        {
            IIterator iterador = ((IIterable)documento).CrearIterador();
            while (!iterador.Fin())
            {
                Alumno aux1 = (Alumno)iterador.Actual();
                aux1.CambiarEstrategia(estrategia);
                iterador.Siguiente();
            }
        }
        public void JornadaDeVentas(IColeccionable listadevendedores)
        {
            GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
            IIterator iterador = ((IIterable)listadevendedores).CrearIterador();
            while (!iterador.Fin())
            {
                Vendedor aux1 = (Vendedor)iterador.Actual();
                aux1.Venta(aleatorio.NumeroAleatorio(0, 7000));
                iterador.Siguiente();
            }
        }
        public void Opciones_menu()
        {
            Console.WriteLine("01- Uso de interfaces-Informar-FactoryMethod");
            Console.WriteLine("02- Uso de interfaces");
            Console.WriteLine("03- Uso de interfaces");
            Console.WriteLine("04- Uso de interfaces");
            Console.WriteLine("05- Uso de interfaces");
            Console.WriteLine("06- Uso de interfaces");
            Console.WriteLine("07- Uso de interfaces");
            Console.WriteLine("08- Uso de interfaces");
            Console.WriteLine("09- Uso de interfaces");
            Console.WriteLine("10- Uso de interfaces");
        }
        public void Opciones_Fabrica()
        {
            Console.WriteLine("01-Numero");
            Console.WriteLine("02-Persona");
            Console.WriteLine("03-Alumno");
            Console.WriteLine("04-Vendedor");
            Console.WriteLine("05-VendedorPauperrimo");
            Console.WriteLine("06-Gerente");
            Console.WriteLine("07-ClaveValor");
            Console.WriteLine("08-AlumnoMuyEstudioso");
            Console.WriteLine("09-ProxyAlumno");
            Console.WriteLine("10-ProxyAlumnoMuyEstudioso");
        }
    }
}
