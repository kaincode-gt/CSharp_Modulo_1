using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1001
{
    class Program
    {
        // 1) Permitir al usuario escribir dos números y mostrar en pantalla cuál de los 
        // dos es el más grande. Si son iguales, mostrar cualquiera.

        static void Main(string[] args)
        {
            while(true)
            { 
                try
                {
                    int n1, n2;
                    Console.Write("Introduzca el primer número: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("Introduzca el segundo número: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("El número mayor es: " + Math.Max(n1, n2));
                    Console.Read();
                    break;
                }
                catch
                {
                    Console.WriteLine("Asegúrese de que el valor es númerico.");
                }
            }
        }
    }
}
