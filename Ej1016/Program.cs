using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1016
{
    class Program
    {
        // 16) Escribir un método que acepte una lista de strings y escriba en la consola
        // el primer caracter de cada uno de los strings.

        static void Main(string[] args)
        {
            List<string> palabras = new List<string> { "Batman", "Robin", "Joker", "Pingüino", "Dos Caras"};
            EscribirPrimerCaracter(palabras);
            Console.Read();
        }

        /// <summary>
        /// Escribe el primer caracter de una lista de cadenas
        /// </summary>
        /// <param name="cadenas">Lista de strings</param>
        static void EscribirPrimerCaracter(List<string> cadenas)
        {
            foreach (string s in cadenas)
            {
                Console.WriteLine(s.First());
            }
        }
    }
}
