using System;
namespace FechasYEdades
{
    class Funciones
    {
        public static string ReadData(string message)
        {
            bool itsCorrect = false;
            string input = "";
            while (!itsCorrect)
            {
                Console.Clear();
                Console.Write(message);
                input = Console.ReadLine();
                itsCorrect = Funciones.ValidateData(input);
            }
            return input;
        }
        private static bool ValidateData(string input)
        {
            bool itsCorrect = false;
            const int position = 3;
            input = Console.ReadLine();
            if (input != "")
            {
                if (input.IndexOf('/') == -1)
                {
                    Messages.FailData();
                }
                else
                {
                    string[] dateSplited = input.Split('/');
                    int[] comprobatedNum = new int[dateSplited.Length];

                    if (dateSplited.Length != position)
                    {
                        Messages.FailData();
                    }
                    else
                    {
                        int counter = 0;
                        bool end = false;
                        while (!end)
                        {
                            if (counter >= dateSplited.Length)
                            {
                                end = true;
                            }
                            else
                            {
                                if (!Int32.TryParse(dateSplited[counter], out comprobatedNum[counter]))
                                {
                                    Messages.FailData();
                                    end = true;
                                }
                                else
                                {
                                    counter++;
                                }
                            }
                        }
                        if (!Funciones.ValidateDate(comprobatedNum,dateSplited))
                        {
                            Messages.FailData();
                        }

                    }
                }
            }
            else
            {
                Messages.FailData();
            }
            return itsCorrect;
        }
        private static bool ValidateDate(int[] comprobatedNum, string[]dates)
        {
            bool result = false;//****************************************************************************
            int[,] diasMeses = new int[,] { { 1, 31 }, { 2, 28/*año bisiesto*/ }, { 3, 31 }, { 4, 30 }, { 5, 31 }, { 6, 30 }, { 7, 31 }, { 8, 31 }, { 9, 30 }, { 10, 31 }, { 11, 30 }, { 12, 31 } };
            if (dates[1].Length == 2) // Primero va el mes para poder comprobar luego los días del mes 28-31 
            {
                if ((comprobatedNum[1] > 12) || (comprobatedNum[1] < 1))
                {
                    if (comprobatedNum[] )
                    {

                    }
                    if (dates[0].Length == 2)
                    {
                        if (dates[2].Length == 4)
                        {
                            result = true;
                        }
                        else
                        {
                            Messages.FailData();
                        }
                    }
                    else
                    {
                        Messages.FailData();
                    }
                }
                
            }
            else
            {
                Messages.FailData();
            }
            return result;
        }
        //La edad en años correspondiente a cada fecha para la fecha actual, en años y en días.
    }
}
