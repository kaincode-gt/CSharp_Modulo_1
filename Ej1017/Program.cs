using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1017
{
    class Program
    {

        // 17) Escribir un método que acepte una lista de strings y escriba en la consola el último
        // caracter de cada uno de los strings.

        static void Main(string[] args)
        {
            List<string> palabras = new List<string> { "Batman", "Robin", "Joker", "Pingüino", "Dos Caras" };
            EscribirUltimoCaracter(palabras);
            Console.Read();
        }

        /// <summary>
        /// Escribe el último caracter de una lista de cadenas
        /// </summary>
        /// <param name="cadenas">Lista de strings</param>
        static void EscribirUltimoCaracter(List<string> cadenas)
        {
            foreach (string s in cadenas)
            {
                Console.WriteLine(s.Last());
            }
        }
    }
}
