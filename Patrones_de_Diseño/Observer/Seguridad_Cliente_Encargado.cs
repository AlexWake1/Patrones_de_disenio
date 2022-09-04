using Patrones_de_Diseño.Comparables;

namespace Patrones_de_Diseño.Observer
{
    class Seguridad : IObservador
    {
        public Seguridad()
        {

        }
        public void Reaccionar(iComparable v)
        {
            Console.WriteLine("Seguridad: No robes, " + ((VendedorPauperrimo)v).Nombre);
            Console.WriteLine("");

        }
        public void Actualizar(iComparable v)
        {
            if (((VendedorPauperrimo)v).Accion == 1)
            {
                Reaccionar(v);
            }
        }
    }
    class Cliente : IObservador
    {
        public Cliente()
        {
        }
        public void Reaccionar(iComparable v)
        {
            Console.WriteLine("Cliente: Tengo una consulta, " + ((VendedorPauperrimo)v).Nombre);
            Console.WriteLine("");
        }
        public void Actualizar(iComparable v)
        {
            if (((VendedorPauperrimo)v).Accion == 2)
            {
                Reaccionar(v);
            }
        }
    }
    class Encargado : IObservador
    {
        public Encargado()
        {
        }
        public void Reaccionar(iComparable v)
        {
            Console.WriteLine("Encargado: Dejá de molestar, " + ((VendedorPauperrimo)v).Nombre);
            Console.WriteLine("");
        }
        public void Actualizar(iComparable v)
        {
            if (((VendedorPauperrimo)v).Accion == 3)
            {
                Reaccionar(v);
            }
        }
    }
}
