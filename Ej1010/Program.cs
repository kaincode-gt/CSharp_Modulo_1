using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1010
{
    class Program
    {
        // 10) Escribir un método que acepte una lista de números y devuelva el número más grande.

        static void Main(string[] args)
        {
            List<int> listaNum = new List<int> { 5,6,4,3,1};
            Console.WriteLine("El valor máximo de la lista es " + ValorMáximo(listaNum));
            Console.Read();
        }

        /// <summary>
        /// Devuelve el valor máximo contenido en una lista de enteros
        /// </summary>
        /// <param name="numeros">Lista de valores</param>
        /// <returns></returns>
        static int ValorMáximo(List<int> numeros)
        {
            return numeros.Max();
        }
    }
}
