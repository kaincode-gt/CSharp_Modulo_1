using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1013
{
    class Program
    {
        // 13) Escribir un método que acepte una lista con números y devuelva dicha
        // lista en orden invertido.

        static void Main(string[] args)
        {
            List<int> listaNum = new List<int> { 5,6,6,62,5,1,23,56 };
            Console.WriteLine("Lista original:\n" + Mostrar(listaNum));
            List<int> listaInvertida = InvertirLista(listaNum);
            Console.WriteLine("Lista invertida:\n" + Mostrar(listaInvertida));
            Console.Read();
        }

        /// <summary>
        /// Invierte una lista de números enteros
        /// </summary>
        /// <param name="valores">Lista de valores</param>
        /// <returns>Lista invertida</returns>
        static List<int> InvertirLista(List<int> valores)
        {
            valores.Reverse();
            return valores;
        }

        /// <summary>
        /// Da formato de texto a una lista de enteros para ser mostrados en pantalla.
        /// </summary>
        /// <param name="valores">Lista de valores enteros</param>
        /// <returns></returns>
        static string Mostrar(List<int> valores)
        {
            string output = "{ ";
            foreach (int val in valores)
            {
                output += val + ",";
            }
            output = output.Substring(0, output.Length - 1) + " }";
            return output;
        }
    }
}
