using System;

namespace FechasYEdades
{
    class Messages
    {
        /// <summary>
        /// Presenta una portada
        /// </summary>
        public static void ShowIntro()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("COMPROBANTE DE FECHAS Y EDADES");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" Pulse una tecla para empezar ");
            Console.WriteLine("------------------------------");
            Console.ReadKey(true);
        }
        /// <summary>
        /// Muestra un mensaje de aviso
        /// </summary>
        public static void Print(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
