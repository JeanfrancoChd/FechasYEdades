using System;

namespace FechasYEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Messages.ShowIntro();
            DateTime dateOne = Functions.ReadData("Introduce la primera fecha en formato dd/mm/yyyy: ");
            DateTime dateTwo = Functions.ReadData("Introduce la segunda fecha en formato dd/mm/yyyy: ");
            //La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
            DateTime currentDate = DateTime.Today;
            string diffOne = Functions.DiffDate(dateOne, currentDate);
            string diffTwo = Functions.DiffDate(dateTwo, currentDate);
            Messages.Print(diffOne + "\n" + diffTwo);
            Console.WriteLine("Pulsa una tecla para terminar...");
            Console.ReadKey();

        }
    }
}

