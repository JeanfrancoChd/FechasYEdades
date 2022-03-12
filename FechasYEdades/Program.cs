using System;

namespace FechasYEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.ShowIntro();
            string dateOne = Funciones.ReadData("Introduce la primera fecha en formato dd/mm/yyyy: ");
            string dateTwo = Funciones.ReadData("Introduce la segunda fecha en formato dd/mm/yyyy: ");
            DateTime data = DateTime.Today;             
        }
    }
}

