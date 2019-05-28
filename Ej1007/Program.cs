using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1007
{
    class Program
    {
        // 7) Escribir un método que acepte una lista de números y devuelva el producto de dichos números.

        static void Main(string[] args)
        {
            List<double> listaNum = new List<double> { 3, 5, 2, 3 };
            double resultado = ProductoNumeros(listaNum);

            Console.WriteLine("Resultado: " + resultado);
            Console.Read();
        }

        /// <summary>
        /// Calcula el producto de una lista de números
        /// </summary>
        /// <param name="numeros">Lista de números a multiplicar</param>
        /// <returns></returns>
        static double ProductoNumeros(List<double> numeros)
        {
            double resultado = (numeros.Count>0) ? 1 : 0;

            foreach (double n in numeros)
            {
                resultado *= n;
            }
            return resultado;
        }
    }
}
