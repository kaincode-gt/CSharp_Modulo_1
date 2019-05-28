using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1014
{
    class Program
    {
        // 14) Escribir un método que acepte una lista de números y devuelva una
        // lista con los mismos números ordenados de menor a mayor.

        static void Main(string[] args)
        {
            List<int> listaNum = new List<int> { 5, 6, 6, 62, 5, 1, 23, 56 };
            Console.WriteLine("Lista original:\n" + Mostrar(listaNum));
            List<int> listaOrdenada = OrdenarLista(listaNum);
            Console.WriteLine("Lista ordenada:\n" + Mostrar(listaOrdenada));
            Console.Read();
        }

        /// <summary>
        /// Ordena una lista de enteros de menor a mayor
        /// </summary>
        /// <param name="valores">Lista de valores</param>
        /// <returns>Lista ordenada</returns>
        static List<int> OrdenarLista(List<int> valores)
        {
            valores.Sort();
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
