using System;

namespace FechasYEdades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear booleanos para la utilizacion de fechas AC/DC
            bool negative1 = false;
            bool negative2 = false;
            //Muestra la pantalla de inicio del programa
            Messages.ShowIntro();         
            //Pedir por teclado las fechas 
            DateTime dateOne = Functions.ReadData("Introduce la primera fecha en formato dd/mm/yyyy: ",ref negative1);
            DateTime dateTwo = Functions.ReadData("Introduce la segunda fecha en formato dd/mm/yyyy: ",ref negative2);
            //calcular la edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
            DateTime currentDate = DateTime.Today;
            string diffOne = Functions.DiffDate(dateOne, currentDate,negative1);
            string diffTwo = Functions.DiffDate(dateTwo, currentDate,negative2);
            //Mostrar la diferencia entre ellas
            string diffBetween = Functions.DatesDiff(dateOne, dateTwo);            
            Messages.Print( diffOne + "\n" + diffTwo + "\n\n\n" + diffBetween);
            //Fin de programa
            Console.ReadKey();
        }
    }
}

