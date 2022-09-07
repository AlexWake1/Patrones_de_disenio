using Patrones_de_Diseño.Adapter;
using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Command;
using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Decorator;
using Patrones_de_Diseño.Factory_method;
using Patrones_de_Diseño.Metodos_Auxiliares;
using Patrones_de_Diseño.Proxy;
using Patrones_de_Diseño.Strategy;

bool bucle = true;
while (bucle)
{
    Console.Clear();
    Metodos.Opciones_menu();
    Console.Write("consola> ");
    int opcion = LectorDeDatos.NumeroPorTeclado();

    switch (opcion)
    {
        case 1:

            var cola = new Cola();
            var pila = new Pila();

            Console.Clear();
            Console.WriteLine("01-Uso de interfaces");
            Console.WriteLine("---");
            Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Cola': ");
            Console.WriteLine("---");
            Metodos.Opciones_Fabrica();
            Console.WriteLine("---");
            Console.Write("consola> ");
            int aux = LectorDeDatos.NumeroPorTeclado();
            Metodos.Llenar(cola, aux);

            Metodos.Informar_1(cola);
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("01-Uso de interfaces");
            Console.WriteLine("---");
            Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Pila': ");
            Console.WriteLine("---");
            Metodos.Opciones_Fabrica();
            Console.WriteLine("---");
            Console.Write("consola> ");
            aux = LectorDeDatos.NumeroPorTeclado();
            Metodos.Llenar(pila, aux);

            Metodos.Informar_1(pila);
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 2:
            var cola2 = new Cola();
            var pila2 = new Pila();
            var conjunto2 = new Conjunto();
            var diccionario2 = new Diccionario();

            Console.Clear();
            Console.WriteLine("02-Uso de Iterator");

            Metodos.Llenar(cola2, 1);
            Metodos.Llenar(pila2, 1);
            Metodos.Llenar(conjunto2, 1);
            Metodos.Llenar(diccionario2, 7);

            Metodos.ImprimirElementos(cola2);
            Metodos.ImprimirElementos(pila2);
            Metodos.ImprimirElementos(conjunto2);
            Metodos.ImprimirElementos(diccionario2);

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            break;

        case 3:
            var cola3 = new Cola();

            Console.Clear();
            Console.WriteLine("03-Uso de Strategy");

            Metodos.Llenar(cola3, 3);

            Metodos.CambiarEstrategia(cola3, new PorDni());
            Console.WriteLine("Estrategia de comparación: Por DNI");
            Metodos.Informar_1(cola3);
            Console.WriteLine();

            Metodos.CambiarEstrategia(cola3, new PorNombre());
            Console.WriteLine("Estrategia de comparación: Por nombre");
            Metodos.Informar_1(cola3);
            Console.WriteLine();

            Metodos.CambiarEstrategia(cola3, new PorPromedio());
            Console.WriteLine("Estrategia de comparación: Por promedio");
            Metodos.Informar_1(cola3);
            Console.WriteLine();

            Metodos.CambiarEstrategia(cola3, new PorLegajo());
            Console.WriteLine("Estrategia de comparación: Por legajo");
            Metodos.Informar_1(cola3);
            Console.WriteLine();

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 4:
            var cola4 = new Cola();
            var pila4 = new Pila();
            int a;
            int b;

            Console.Clear();
            Console.WriteLine("04- Uso de Factory");
            Console.WriteLine("---");
            Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Cola': ");
            Console.WriteLine("---");
            Metodos.Opciones_Fabrica();
            Console.Write("consola> ");
            Metodos.Llenar(cola4, a = LectorDeDatos.NumeroPorTeclado());

            Console.Clear();
            Console.WriteLine("04- Uso de Factory");
            Console.WriteLine("---");
            Console.WriteLine("Elija una opción agregar iComparables en el IColeccionable 'Pila': ");
            Console.WriteLine("---");
            Metodos.Opciones_Fabrica();
            Console.Write("consola> ");
            Metodos.Llenar(pila4, b = LectorDeDatos.NumeroPorTeclado());

            Console.Clear();
            Console.WriteLine("04- Uso de Factory");
            Metodos.Informar(cola4, a);
            Metodos.Informar(pila4, b);

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 5:

            Console.Clear();
            Console.WriteLine("05- Uso de Observer");

            var cola5 = new Cola();
            var pila5 = new Pila();
            var gerente = new Gerente();

            Metodos.Llenar2(cola5);
            Metodos.AsignarGerente(cola5, gerente);
            Metodos.JornadaDeVentas(cola5);

            Metodos.Llenar2(pila5);
            Metodos.AsignarGerente(pila5, gerente);
            Metodos.JornadaDeVentas(pila5);

            gerente.Cerrar();

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 6:
            Console.Clear();
            Console.WriteLine("06- Uso de Adapter");

            var teacher = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                AlumnoAdapter student = new AlumnoAdapter((Alumno)FabricaAlumno.CrearComparable(3));
                AlumnoAdapter smartStudent = new AlumnoAdapter((AlumnoMuyEstudioso)FabricaAlumno.CrearComparable(8));
                teacher.goToClass(student);
                teacher.goToClass(smartStudent);
            }
            teacher.teachingAClass();

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 7:
            Console.Clear();
            Console.WriteLine("07- Uso de Decorator");

            Teacher profesor = new Teacher();

            for (int i = 0; i < 10; i++)
            {
                IAlumno alumno = (Alumno)Fabrica.CrearComparable(3);
                IAlumno decorador1 = new DecoradorLegajo(alumno);
                IAlumno decorador2 = new DecoradorLetras(decorador1);
                IAlumno decorador3 = new DecoradorPromocion(decorador2);
                IAlumno decorador4 = new DecoradorRecuadro(decorador3);

                IAlumno alumnoEstudioso = (AlumnoMuyEstudioso)Fabrica.CrearComparable(8);
                IAlumno decorador1Estudioso = new DecoradorLegajo(alumnoEstudioso);
                IAlumno decorador2Estudioso = new DecoradorLetras(decorador1Estudioso);
                IAlumno decorador3Estudioso = new DecoradorPromocion(decorador2Estudioso);
                IAlumno decorador4Estudioso = new DecoradorRecuadro(decorador3Estudioso);

                Student student_decorated = new AlumnoAdapter(decorador4);
                Student studentEstudioso_decorated = new AlumnoAdapter(decorador4Estudioso);

                profesor.goToClass(student_decorated);
                profesor.goToClass(studentEstudioso_decorated);
            }

            profesor.teachingAClass();

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 8:
            Console.Clear();
            Console.WriteLine("08- Uso de Proxy");

            Teacher profesor8 = new Teacher();
            for (int i = 0; i < 10; i++)
            {
                AlumnoAdapter aux8 = new AlumnoAdapter((ProxyAlumno)Fabrica.CrearComparable(9));
                profesor8.goToClass(aux8);
            }
            for (int i = 0; i < 10; i++)
            {
                AlumnoAdapter aux8 = new AlumnoAdapter((ProxyAlumnoMuyEstudioso)Fabrica.CrearComparable(10));
                profesor8.goToClass(aux8);
            }

            profesor8.teachingAClass();

            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;
        case 9:

            Console.Clear();
            Console.WriteLine("09- Uso de Command");

            var cola9 = new Cola();
            var pila9 = new Pila();
            var conjunto9 = new Conjunto();
            var aula = new Aula();

            cola9.setOrdenInicio(new OrdenInicio(aula));
            cola9.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            cola9.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            Metodos.Llenar(cola9, 3);
            Metodos.Llenar(cola9, 8);

            pila9.setOrdenInicio(new OrdenInicio(aula));
            pila9.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila9.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            Metodos.Llenar(pila9, 3);
            Metodos.Llenar(pila9, 8);


            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();

            break;

        default:
            break;
    }

    Console.WriteLine("Salir s/n");
    Console.Write("consola> ");

    string? respuesta = Console.ReadLine();
    respuesta?.ToLower();
    if (respuesta == "s" || respuesta == "si")
    {
        bucle = false;
    }
}
