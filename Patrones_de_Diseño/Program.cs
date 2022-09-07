using Patrones_de_Diseño;
using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Metodos_Auxiliares;

var aula = new Aula();
var metodos = new Metodos_Auxiliares();


bool bucle = true;
while (bucle)
{
    Console.Clear();
    var aleatorio = new GeneradorDeDatosAleatorios();
    metodos.Opciones_menu();
    Console.Write("consola> ");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            try
            {
                var cola = new Cola();
                var pila = new Pila();

                Console.Clear();
                Console.WriteLine("01-Uso de interfaces");
                Console.WriteLine("---");
                Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Cola': ");
                Console.WriteLine("---");
                metodos.Opciones_Fabrica();
                Console.WriteLine("---");
                Console.Write("consola> ");
                int aux = int.Parse(Console.ReadLine());
                metodos.Llenar(cola, aux);

                metodos.Informar(cola, aux);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("01-Uso de interfaces");
                Console.WriteLine("---");
                Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Pila': ");
                Console.WriteLine("---");
                metodos.Opciones_Fabrica();
                Console.WriteLine("---");
                Console.Write("consola> ");
                aux = int.Parse(Console.ReadLine());
                metodos.Llenar(pila, aux);

                metodos.Informar(pila, aux);
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Algo salió mal");
            }
            break;

        case 2:

            Console.Clear();
            Console.WriteLine("02-Uso de Iterator");

            var cola2 = new Cola();
            var pila2 = new Pila();
            var conjunto2 = new Conjunto();
            var diccionario2 = new Diccionario();

            metodos.Llenar(cola2, 1);
            metodos.Llenar(pila2, 1);
            metodos.Llenar(conjunto2, 1);
            metodos.Llenar(diccionario2, 7);

            metodos.ImprimirElementos(pila2);
            metodos.ImprimirElementos(cola2);
            metodos.ImprimirElementos(conjunto2);
            metodos.ImprimirElementos(diccionario2);

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;
        case 6:

            break;
        case 7:

            break;
        case 8:

            break;
        case 9:

            break;
        case 10:

            break;
        case 11:

            break;

        default:
            Console.WriteLine("otro numero");
            break;
    }
    Console.WriteLine("Salir s/n");
    Console.Write("consola> ");
    string? respuesta = Console.ReadLine();
    respuesta?.ToLower();
    if (respuesta=="s")
    {
        bucle = false;
    }
}


//      ***Ejercicio 2***       //



//Teacher profesor = new Teacher();
//for (int i = 0; i < 10; i++)
//{
//    AlumnoAdapter aux = new AlumnoAdapter((ProxyAlumno)Fabrica.CrearComparable(9));
//    profesor.goToClass(aux);
//}
//for (int i = 0; i < 10; i++)
//{
//    AlumnoAdapter aux = new AlumnoAdapter((ProxyAlumnoMuyEstudioso)Fabrica.CrearComparable(10));
//    profesor.goToClass(aux);
//}
//profesor.teachingAClass();

//      ***Ejercicio 2***       //

//      ***Ejercicio 10***       //

//      ***COLA***      //


//c1.setOrdenInicio(new OrdenInicio(aula));
//c1.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
//c1.setOrdenAulaLlena(new OrdenAulaLlena(aula));

//Llenar(c1, 3);
//Llenar(c1, 8);


//      ***COLA***      //


//      ***PILA***      //


//p1.setOrdenInicio(new OrdenInicio(aula));
//p1.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
//p1.setOrdenAulaLlena(new OrdenAulaLlena(aula));

//Llenar(p1, 3);
//Llenar(p1, 8);


//      ***PILA***      //


//      ***CONJUNTO***       //


//conj1.setOrdenInicio(new OrdenInicio(aula));
//conj1.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
//conj1.setOrdenAulaLlena(new OrdenAulaLlena(aula));

//Llenar(conj1, 3);
//Llenar(conj1, 8);


//      ***CONJUNTO***       //


//      ***DICCIONARIO***      // con diccionario no funciona porque solo funciona con clavevalor


//dic1.setOrdenInicio(new OrdenInicio(aula));
//dic1.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
//dic1.setOrdenAulaLlena(new OrdenAulaLlena(aula));

//Llenar(dic1, 3);
//Llenar(dic1, 8);


//      ***DICCIONARIO***       //


//      ***EJERCICIO 10***       //
