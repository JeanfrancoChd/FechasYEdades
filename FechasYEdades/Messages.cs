using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechasYEdades
{
    class Messages
    {
        public static void ShowIntro()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("COMPROBANTE DE FECHAS Y EDADES");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" Pulse una tecla para empezar ");
            Console.WriteLine("------------------------------");
            Console.ReadKey(true);
        }
        public static void FailData()
        {
            Console.Clear();
            Console.WriteLine("Entrada de datos fallida. Formato erróneo.");
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
        public static void Print(string mensaje)
        {
            Console.Clear();
            Console.WriteLine(mensaje);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
