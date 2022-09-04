using Patrones_de_Diseño.Comparables;

namespace Patrones_de_Diseño.Factory_method
{
    class FabricaGerente : Fabrica
    {
        public override iComparable CrearComparable()
        {
            return new Gerente();
        }
        public override iComparable CrearComparablePorTeclado()
        {
            return new Gerente();
        }
    }
}
