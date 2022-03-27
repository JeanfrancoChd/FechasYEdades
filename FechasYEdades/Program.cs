using System;

namespace FechasYEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.ShowIntro();
            DateTime dateOne = Funciones.ReadData("Introduce la primera fecha en formato dd/mm/yyyy: ");
            DateTime dateTwo = Funciones.ReadData("Introduce la segunda fecha en formato dd/mm/yyyy: ");
            //La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
            DateTime DiaActual = DateTime.Today;
            string diferenciasUno = Funciones.DiffDate(dateOne, DiaActual);
            string diferenciasDos = Funciones.DiffDate(dateTwo, DiaActual);
            Messages.Print(diferenciasUno + "\n" + diferenciasDos);
            Console.ReadKey();

        }
    }
}

