using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1012
{
    class Program
    {
        // 12) Escribir un fizzbuzz: Iterar los números del uno al cien, y cuando llegues
        // a un número que sea múltiplo de 3 (el 6 por ejemplo), escribir en la consola "Fizz",
        //cuando llegues a un número que sea múltiplo de 5 (el 20 por ejemplo) escribir en la 
        // consola "Buzz", cuando llegues a un número que sea múltiplo de 3 y 5 (el 30 por ejemplo)
        // escribir FizzBuzz en la consola.

        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("Fizz");
                    }
                    if (i % 5 == 0)
                    {
                        Console.Write("Buzz");
                    }
                    Console.Write("\n");
                }
            }
            Console.Read();
        }
    }
}
