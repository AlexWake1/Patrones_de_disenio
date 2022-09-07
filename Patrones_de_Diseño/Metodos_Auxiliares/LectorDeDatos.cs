using System;

namespace Patrones_de_Diseño.Metodos_Auxiliares
{
    public static class LectorDeDatos
    {
        public static int NumeroPorTeclado()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static string StringPorTeclado()
        {
            try
            {
                return Console.ReadLine();
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
