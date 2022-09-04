using Patrones_de_Diseño.Coleccionable;
using Patrones_de_Diseño.Iterator;
using Patrones_de_Diseño.Observer;
using System;
using System.Collections.Generic;

namespace Patrones_de_Diseño.Comparables
{
    public class Gerente : IObservador, iComparable
    {
        private Conjunto mejores = new Conjunto();//acá puedo usar la clase conjunto, no hay problema con la accesibilidad
        public Gerente()
        {
        }
        public void Cerrar()
        {
            Console.WriteLine("*** MEJORES VENDEDORES ***");
            IIterator aux = mejores.CrearIterador();
            while (!aux.Fin())
            {
                Console.WriteLine(aux.Actual());
                aux.Siguiente();
            }
        }
        public void Venta(int monto, Vendedor vendedor)
        {
            if (monto >= 5000)
            {
                mejores.Agregar(vendedor);
                vendedor.AumentaBonus();
            }
        }
        public void Actualizar(iComparable vendedor)
        {
            Venta(((Vendedor)vendedor).GetUltimaventa, (Vendedor)vendedor);
        }

        public bool SosIgual(iComparable x)
        {
            throw new NotImplementedException();
        }

        public bool SosMenor(iComparable x)
        {
            throw new NotImplementedException();
        }

        public bool SosMayor(iComparable x)
        {
            throw new NotImplementedException();
        }
    }
}
