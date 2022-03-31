using System;

namespace FechasYEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            bool negative1 = false;
            bool negative2 = false;
            Messages.ShowIntro();            
            DateTime dateOne = Functions.ReadData("Introduce la primera fecha en formato dd/mm/yyyy: ",ref negative1);
            DateTime dateTwo = Functions.ReadData("Introduce la segunda fecha en formato dd/mm/yyyy: ",ref negative2);
            //La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
            DateTime currentDate = DateTime.Today;
            string diffOne = Functions.DiffDate(dateOne, currentDate,negative1);
            string diffTwo = Functions.DiffDate(dateTwo, currentDate,negative2);
            Messages.Print(diffOne + "\n" + diffTwo);
            Console.WriteLine("Pulsa una tecla para terminar...");
            Console.ReadKey();

        }
    }
}

