using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1005
{
    class Program
    {
        // 5) Utilizando un iterador escribir en pantalla los números del 1 al 100 de dos en dos.

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i + ", " + (i + 1));
                }
            }
            Console.Read();
        }
    }
}
