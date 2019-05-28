using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1011
{
    class Program
    {
        // 11) Escribir un método que acepte un datetime que represente la fecha
        // de nacimiento de una persona y retornar su edad al día de hoy.

        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(1990, 04, 19);
            var edad = CalcularEdad(fecha);
            Console.WriteLine("Edad con fecha " + fecha.ToShortDateString() + ": " + edad + " años.");
            Console.Read();
        }

        /// <summary>
        /// Calcula la edad actual a partir de una fecha de nacimiento
        /// </summary>
        /// <param name="fechaNac">Fecha de nacimiento</param>
        /// <returns></returns>
        static int CalcularEdad(DateTime fechaNac)
        {
            int diff = DateTime.Now.Year - fechaNac.Year;
            int edad = (DateTime.Now.DayOfYear > fechaNac.DayOfYear) ? diff : diff-1;
            return edad;
        }
    }
}
