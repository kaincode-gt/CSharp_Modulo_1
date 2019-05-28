using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1018
{
    class Program
    {
        // 18) Escribir un método que acepte un string y devuelva true si dicho string es un
        // palíndromo, si no lo es devuelve false. Un palíndromo es un texto que es igual al
        // derecho y al revés.Ejemplos: "ana" es un palíndromo, pero "Pirata" no es palíndromo.
        
        static void Main(string[] args)
        {
            List<string> nombres = new List<string> { "Eve","Pedro", "Juan",  "Ana", "Otto" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre + " es un palíndromo : " + EsPalindromo(nombre.ToLower()));
            }
            Console.Read();
        }

        /// <summary>
        /// Comprueba si una cadena de texto es un palíndromo
        /// </summary>
        /// <param name="cadena">cadena de texto</param>
        /// <returns>Verdadero si es un palíndromo</returns>
        static bool EsPalindromo(string cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != cadena[cadena.Length-1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
