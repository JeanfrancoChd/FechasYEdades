using System;
namespace FechasYEdades
{
    public class Functions
    {/// <summary>
     /// Recoge la fecha
     /// </summary>
     /// <returns>La fecha comprobada y correcta</returns>
        public static DateTime ReadData(string message)
        {
            DateTime data = new DateTime();
            bool itsCorrect = false;
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                if (DateTime.TryParse(Console.ReadLine(), out data))
                {
                    itsCorrect = true;
                }
                else
                {
                    Messages.Print("La fecha no es válida. Inténtalo otra vez.");
                }
            }
            while (!itsCorrect);
            return data;
        }
        /// <summary>
        /// Calcula las diferencias y las guarda.
        /// </summary>
        /// <returns>Las diferencias de dias y años</returns>
        public static string DiffDate(DateTime date, DateTime currentDate)
        {
            int year = date.Year;
            int currentYear = currentDate.Year;
            double diffDays = DayDiff(date, currentDate, year, currentYear);
            int diffYear = YearDiff(year, currentYear);
            string diferencias = "Estos son los dias " + diffDays + ". Y estos los años " + diffYear;
            return diferencias;
        }
        /// <summary>
        /// Calcula la diferencia de años.
        /// </summary>
        /// <returns>Diferencia de años en positivo</returns>
        private static int YearDiff(int year, int currentYear)
        {
            if (year < currentYear)
            {
                year = currentYear - year;

            }
            if (year > currentYear)
            {
                year = year - currentYear;
            }
            return year;
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
    }
}
