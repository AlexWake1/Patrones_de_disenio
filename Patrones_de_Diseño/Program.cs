using Patrones_de_Diseño;
using Patrones_de_Diseño.Adapter;
using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;
using Patrones_de_Diseño.Factory_method;
using Patrones_de_Diseño.Iterator;
using Patrones_de_Diseño.Proxy;
using Patrones_de_Diseño.Strategy;
using Patrones_de_Diseño.Metodos_Auxiliares;
using System;

var c1 = new Cola();
var p1 = new Pila();
var conj1 = new Conjunto();
var dic1 = new Diccionario();
var aula = new Aula();
var metodos = new Metodos_Auxiliares();

while (true)
{
    Console.Clear();
    var aleatorio = new GeneradorDeDatosAleatorios();
    metodos.Opciones_menu();
    Console.Write("consola> ");
    int a = int.Parse(Console.ReadLine());

    switch (a)
	{
		case 1:
            try
            {
                Console.Clear();
                Console.WriteLine("01-Uso de interfaces");
                Console.WriteLine("---");
                Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Cola': ");
                Console.WriteLine("---");
                metodos.Opciones_Fabrica();
                Console.WriteLine("---");
                Console.Write("consola> ");
                int aux = int.Parse(Console.ReadLine());
                metodos.Llenar(c1, aux);

                metodos.Informar(c1, aux);
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
                metodos.Llenar(p1, aux);

                metodos.Informar(p1, aux);
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
