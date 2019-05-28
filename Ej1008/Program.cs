using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1008
{
    class Program
    {
        // 8) Escribir un método que acepte un int y te devuelva el factorial de dicho número

        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nResultado: " + Factorial(n1));
            Console.Read();
        }

        /// <summary>
        /// Calcula el factorial de un número entero.
        /// </summary>
        /// <param name="numero">Número base</param>
        /// <returns></returns>
        static int Factorial(int numero)
        {
            int resultado = 1;
            while (numero > 0)
            {
                resultado *= numero;
                numero--;
            }
            return resultado;
        }
    }
}
