using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Factory_method;
using Patrones_de_Diseño.Iterator;
using Patrones_de_Diseño.Observer;
using Patrones_de_Diseño.Strategy;

namespace Patrones_de_Diseño.Metodos_Auxiliares
{
    public static class Metodos
    {
        public static void Llenar(IColeccionable lista, int OPCION)
        {
            for (int i = 0; i < 20; i++)
            {
                lista.Agregar(Fabrica.CrearComparable(OPCION));
            }
        }

        public static void Llenar2(IColeccionable lista)
        {
            for (int i = 0; i < 40; i++)
            {
                lista.Agregar(Fabrica.CrearComparable(GeneradorDeDatosAleatorios.NumeroAleatorio(4, 6)));
            }
        }


        public static void Informar(IColeccionable lista, int numdecomparable)
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
        public static void Informar_1(IColeccionable lista)
        {
            Console.WriteLine();
            Console.WriteLine(lista);
            Console.WriteLine("Menor elemento en el coleccionable... " + lista.Minimo());
            Console.WriteLine("Mayor elemento en el coleccionable... " + lista.Maximo());
        }
        public static void ImprimirElementos(IIterable iterable)
        {
            Impresora.Imprimir(iterable);
        }
        public static void CambiarEstrategia(IColeccionable documento, IStrategy_Alumno estrategia)
        {
            IIterator iterador = ((IIterable)documento).CrearIterador();
            while (!iterador.Fin())
            {
                Alumno aux1 = (Alumno)iterador.Actual();
                aux1.CambiarEstrategia(estrategia);
                iterador.Siguiente();
            }
        }
        public static void AsignarGerente(IColeccionable documento, Gerente gerente)
        {
            IIterator iterador = ((IIterable)documento).CrearIterador();
            iterador.Primero();
            while (!iterador.Fin())
            {
                var aux1 = (IObservado)iterador.Actual();
                aux1.AgregarObservador(gerente);
                iterador.Siguiente();
            }
        }
        public static void JornadaDeVentas(IColeccionable listadevendedores)
        {
            IIterator iterador = ((IIterable)listadevendedores).CrearIterador();
            iterador.Primero();
            if (iterador.Actual().GetType() == typeof(VendedorPauperrimo))
            {
                while (!iterador.Fin())
                {
                    if (iterador.Actual().GetType() == typeof(VendedorPauperrimo))
                    {
                        var aux1 = (VendedorPauperrimo)iterador.Actual();
                        aux1.Venta(GeneradorDeDatosAleatorios.NumeroAleatorio(0, 7000));
                        iterador.Siguiente();
                    }
                    else
                    {
                        var aux1 = (Vendedor)iterador.Actual();
                        aux1.Venta(GeneradorDeDatosAleatorios.NumeroAleatorio(0, 7000));
                        iterador.Siguiente();
                    }
                }
            }
        }
        public static void Opciones_menu()
        {
            Console.WriteLine("01- Uso de interfaces");
            Console.WriteLine("02- Uso de Iterator");
            Console.WriteLine("03- Uso de Strategy");
            Console.WriteLine("04- Uso de Factory-Method");
            Console.WriteLine("05- Uso de Observer");
            Console.WriteLine("06- Uso de Adapter");
            Console.WriteLine("07- Uso de Decorator");
            Console.WriteLine("08- Uso de Proxy");
            Console.WriteLine("09- Uso de Command");
        }
        public static void Opciones_Fabrica()
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
