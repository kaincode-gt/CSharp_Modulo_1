using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1002
{
    class Program
    {
        // 2) Escribir un método que acepte un número y devuelva True si el número es par, o false si es impar

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Introduzca un número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    if (n1 % 2 == 0)
                    {
                        Console.WriteLine("El número es PAR");
                    }
                    else
                    {
                        Console.WriteLine("El número es IMPAR");
                    }
                }
                catch
                {
                    Console.WriteLine("** Asegúrese de introducir un valor numérico **");
                }
            }
        }
    }
}
