using Patrones_de_Diseño.Comparables;
using Patrones_de_Diseño.Metodos_Auxiliares;

namespace Patrones_de_Diseño.Factory_method
{
    abstract class Fabrica : IFabricaDeComprarables
    {
        //protected static GeneradorDeDatosAleatorios aleatorio = new GeneradorDeDatosAleatorios();
        public static iComparable CrearComparable(int quecomparable)
        {
            Fabrica? fabrica = null;
            switch (quecomparable)
            {
                case 1:
                    fabrica = new FabricaNumero();
                    break;
                case 2:
                    fabrica = new FabricaPersona();
                    break;
                case 3:
                    fabrica = new FabricaAlumno();
                    break;
                case 4:
                    fabrica = new FabricaVendedor();
                    break;
                case 5:
                    fabrica = new FabricaVendedorPauperrimo();
                    break;
                case 6:
                    fabrica = new FabricaGerente();
                    break;
                case 7:
                    fabrica = new FabricaClaveValor();
                    break;
                case 8:
                    fabrica = new FabricaAlumnoMuyEstudioso();
                    break;
                case 9:
                    fabrica = new FabricaProxyAlumno();
                    break;
                case 10:
                    fabrica = new FabricaProxyAlumnoMuyEstudioso();
                    break;
                default:
                    break;
            }
            return fabrica.CrearComparable();
        }
        public static iComparable CrearComparablePorTeclado(int quecomparable)
        {
            Fabrica? fabrica = null;
            switch (quecomparable)
            {
                case 1:
                    fabrica = new FabricaNumero();
                    break;
                case 2:
                    fabrica = new FabricaPersona();
                    break;
                case 3:
                    fabrica = new FabricaAlumno();
                    break;
                case 4:
                    fabrica = new FabricaVendedor();
                    break;
                case 5:
                    fabrica = new FabricaVendedorPauperrimo();
                    break;
                case 6:
                    fabrica = new FabricaGerente();
                    break;
                case 7:
                    fabrica = new FabricaClaveValor();
                    break;
                case 8:
                    fabrica = new FabricaAlumnoMuyEstudioso();
                    break;
                case 9:
                    fabrica = new FabricaProxyAlumno();
                    break;
                case 10:
                    fabrica = new FabricaProxyAlumnoMuyEstudioso();
                    break;
            }
            return fabrica.CrearComparablePorTeclado();
        }
        public iComparable CrearComparableAleatorio()
        {
            return Fabrica.CrearComparable(GeneradorDeDatosAleatorios.NumeroAleatorio(1, 10));
        }
        public abstract iComparable CrearComparable();
        public abstract iComparable CrearComparablePorTeclado();
    }
}
