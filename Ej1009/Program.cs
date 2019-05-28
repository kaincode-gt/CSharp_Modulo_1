using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1009
{
    class Program
    {
        // 9) Escribir un método que acepte una lista de números y devuelva su promedio.

        static void Main(string[] args)
        {
            List<double> listaNum = new List<double> { 5, 6, 6, 4 };
            double resultado = CalcularPromedio(listaNum);
            Console.WriteLine("El resultado es: " + resultado);
            Console.Read();
        }

        /// <summary>
        /// Calcula el promedio de una lista de números
        /// </summary>
        /// <param name="numeros">Lista de números</param>
        /// <returns></returns>
        static double CalcularPromedio(List<double> numeros)
        {
            double total =0;
            foreach (double num in numeros)
            {
                total += num;
            }
            return total/ numeros.Count;
        }
    }
}
