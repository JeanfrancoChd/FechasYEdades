using System;
namespace FechasYEdades
{
    public class Functions
    {
        /// <summary>
        /// Recoge la fecha
        /// </summary>
        /// <returns>La fecha comprobada y correcta</returns>
        public static DateTime ReadData(string message,ref bool negative)
        {
            DateTime data = new DateTime();
            string date = "";
            bool itsCorrect = false;
            string error = "";
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                date = Console.ReadLine();
                if (date.Length.Equals(0))
                {
                    Messages.Print("Error. Fecha vacía... ");
                }
                else
                {
                    string[] splittedDate = date.Split('/');
                    if (CheckDate(ref error, splittedDate, date, ref data, ref negative))
                    {
                        itsCorrect = true;
                    }
                    else
                    {
                        Messages.Print(error);
                    }
                }
            }
            while (!itsCorrect);
            return data;
        }

        /// <summary>
        /// Comprueba que la fecha introducida sea una fecha válida.
        /// </summary>
        /// <param name="error">Guarda el error</param>
        /// <param name="splittedDate">Guarda la fecha en un array</param>
        /// <param name="date">Fecha recogida por el usuario</param>
        /// <param name="data">Fecha en DateTime</param>
        /// <returns></returns>
        public static bool CheckDate(ref string error, string[] splittedDate, string date, ref DateTime data, ref bool negative)
        {
            bool leave = false;
            bool itsCorrect = false;
            DateTime today = DateTime.Today;
            while (!leave)
            {
                if (splittedDate.Length != 3)
                {
                    leave = true;
                    error = "Error de formato.";
                }
                else
                {
                    if (Int32.TryParse(splittedDate[0], out int auxDay))
                    {
                        if ((auxDay >= 31) || (auxDay < 0))
                        {
                            leave = true;
                            error = "El día " + auxDay + " no existe.";
                        }
                        else
                        {
                            if (Int32.TryParse(splittedDate[1], out int auxMonth))
                            {
                                if ((auxMonth >= 12) || (auxMonth < 0))
                                {
                                    leave = true;
                                    error = "El mes " + auxMonth + " no existe.";
                                }
                                else
                                {
                                    if (Int32.TryParse(splittedDate[2], out int auxYear))
                                    {
                                        if (auxYear < 0)
                                        {
                                            int newYear = ((auxYear * (-1)) + today.Year);
                                            string newDate = auxDay + "/" + auxMonth + "/" + newYear;
                                            if (DateTime.TryParse(newDate, out data))
                                            {
                                                itsCorrect = true;
                                                negative = true;
                                            }
                                            else
                                            {
                                                error = "El mes " + auxMonth + " no tiene " + auxDay + " días.";
                                            }
                                            leave = true;
                                        }
                                        else
                                        {
                                            if (DateTime.TryParse(date, out data))
                                            {
                                                itsCorrect = true;
                                            }
                                            else
                                            {
                                                error = "El mes " + auxMonth + " no tiene " + auxDay + " días.";
                                            }
                                            leave = true;
                                        }
                                    }
                                    else
                                    {
                                        error = splittedDate[2] + "no es un número.";
                                    }
                                }
                            }
                            else
                            {
                                error = splittedDate[1] + "no es un número.";
                            }
                        }
                    }
                    else
                    {
                        error = splittedDate[0] + "no es un número.";
                    }
                }
            }
            return itsCorrect;
        }

        /// <summary>
        /// Calcula las diferencias y las guarda.
        /// </summary>
        /// <returns>Las diferencias de dias y años</returns>
        public static string DiffDate(DateTime date, DateTime currentDate, bool negative)
        {
            int year = date.Year;
            int currentYear = currentDate.Year;
            double diffDays = DayDiff(date, currentDate, year, currentYear);
            int diffYear = YearDiff(year, currentYear,negative);
            string diferencias = "Diferencia con la fecha actual en días: " + diffDays + ". Y en años: " + diffYear +".";
            return diferencias;
        }
        /// <summary>
        /// Calcula la diferencia de años.
        /// </summary>
        /// <returns>Diferencia de años en positivo</returns>
        private static int YearDiff(int year, int currentYear,bool negative)
        {
           int finalYear = 0;
           if (!negative)
            {
                if (year < currentYear)
                {
                    finalYear = currentYear - year;

                }
                if (year > currentYear)
                {
                    finalYear = year - currentYear;
                }
            }
            else
            {
                finalYear = year;
            }
            return finalYear;
        }
        /// <summary>
        /// Calcula la diferencia de dias
        /// </summary>
        /// <returns>Devuelve la diferencia en dias</returns>
        private static double DayDiff(DateTime date, DateTime currentDate, int year, int currentYear)
        {
            TimeSpan diff;
            double day = 0;
                if (year < currentYear)
                {
                    diff = currentDate - date;
                    day = diff.TotalDays;
                }
                if (year > currentYear)
                {
                    diff = date - currentDate;
                    day = diff.TotalDays;
                }
                if (year.Equals(currentYear))
                {
                    if (date.Month > currentDate.Month)
                    {
                        diff = date - currentDate;
                        day = diff.TotalDays;
                    }
                    if (date.Month < currentDate.Month)
                    {
                        diff = currentDate - date;
                        day = diff.TotalDays;
                    }
                    if (date.Month.Equals(currentDate.Month))
                    {
                        if (date.Day < currentDate.Day)
                        {
                            diff = currentDate - date;
                            day = diff.TotalDays;
                        }
                        if (date.Day > currentDate.Day)
                        {
                            diff = date - currentDate;
                            day = diff.TotalDays;
                        }
                        if (date.Day.Equals(currentDate.Day))
                        {
                            day = 0;
                        }
                    }
                }                 
            return day;
        }
        /// <summary>
        /// Calcula la diferencia entre las dos fechas
        /// </summary>
        /// <param name="dateOne">Primer fecha solicitada</param>
        /// <param name="dateTwo">Segunda fecha solicitada</param>
        /// <returns>Retorna un string concatenado del resultado</returns>
        public static string DatesDiff (DateTime dateOne, DateTime dateTwo)
        {
            string final = "";
            TimeSpan diff;
            double day = 0;
            if(dateOne > dateTwo)
            {
                diff = dateOne - dateTwo;
                day = diff.TotalDays;
                final ="Diferencia en años: " + (dateOne.Year - dateTwo.Year).ToString() + ". Y diferencia en días: " + day;
            }
            if (dateTwo > dateOne)
            {
                diff = dateTwo - dateOne;
                day = diff.TotalDays;
                final = "Diferencia en años: " + (dateTwo.Year - dateOne.Year).ToString() + ". Y diferencia en días: " + day;
            }
            if (dateOne.Equals(dateTwo))
            {
                final = "Las dos fechas son iguales.";
            }
            return final;
        }
    }
}
