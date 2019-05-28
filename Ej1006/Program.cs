using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1006
{
    class Program
    {
        public const int INCREMENTO = 37;

        // 6) Escribir un método que acepte un double que represente un número en
        // grados Celcius y lo transforme a grados Fahrenheit.

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un número: ");
            float cantidad = int.Parse(Console.ReadLine());

            double resultado = CelsiusAFahrenheit(cantidad);
            Console.WriteLine("\n" + cantidad + " grados Celsius son " + resultado + " grados Fahrenheit.");
            Console.Read();
        }

        static double CelsiusAFahrenheit(double grados)
        {
            return grados + INCREMENTO;
        }
    }
}
