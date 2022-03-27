using System;
namespace FechasYEdades
{
    class Funciones
    {
        public static DateTime ReadData(string message)
        {
            DateTime data = new DateTime();
            bool comprobante = false;
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                if (DateTime.TryParse(Console.ReadLine(), out data))
                {
                    comprobante = true;
                }
                else
                {
                    Messages.Print("La fecha no es válida. Inténtalo otra vez.");
                }
            }
            while (!comprobante);
            return data;
        }
        public static string DiffDate(DateTime date, DateTime Hoy)
        {
            int anio = date.Year;
            int anioActual = Hoy.Year;
            double diffDays = YearDiff(date, Hoy, anio, anioActual);
            int diffYear = YearDiff(anio, anioActual);
            string diferencias = "Estos son los dias " + diffDays + ". Y estos los años " + diffYear;
            return diferencias;
        }
        private static int YearDiff(int anio, int anioActual)
        {
            int year = 0;
            if (anio < anioActual)
            {
                year = anioActual - anio;

            }
            if (anio > anioActual)
            {
                year = anio - anioActual;
            }
            return year;
        }
        private static double YearDiff(DateTime fecha, DateTime Hoy, int anio, int anioActual)
        {
            TimeSpan diferencias;
            double Dias = 0;
            if (anio < anioActual)
            {
                diferencias = Hoy - fecha;
                Dias = diferencias.TotalDays;
            }
            if (anio > anioActual)
            {
                diferencias = fecha - Hoy;
                Dias = diferencias.TotalDays;
            }
            if (anio.Equals(anioActual))
            {
                if (fecha.Month > Hoy.Month)
                {
                    diferencias = fecha - Hoy;
                    Dias = diferencias.TotalDays;
                }
                if (fecha.Month < Hoy.Month)
                {
                    diferencias = Hoy - fecha;
                    Dias = diferencias.TotalDays;
                }
                if (fecha.Month.Equals(Hoy.Month))
                {
                    if (fecha.Day < Hoy.Day)
                    {
                        diferencias = Hoy - fecha;
                        Dias = diferencias.TotalDays;
                    }
                    if (fecha.Day > Hoy.Day)
                    {
                        diferencias = fecha - Hoy;
                        Dias = diferencias.TotalDays;
                    }
                    if (fecha.Day.Equals(Hoy.Day))
                    {
                        Dias = 0;
                    }
                }
            }
            return Dias;
        }
    }
}
