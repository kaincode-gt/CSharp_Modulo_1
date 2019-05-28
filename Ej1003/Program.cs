using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1003
{
    class Program
    {
        // 3) Escribir un método que acepte dos strings y devuelva el string con más caracteres.
        // Si ambos tienen la misma cantidad de caracteres, devolver cualquiera de los dos.

        static void Main(string[] args)
        {
            Console.Write("Introduzca la primera cadena: ");
            string cadena1 = Console.ReadLine();
            Console.Write("Introduzca la segunda cadena: ");
            string cadena2 = Console.ReadLine();

            string masLarga = (cadena1.Length >= cadena2.Length) ?  cadena1 : cadena2;

            Console.WriteLine(masLarga + " (" + masLarga.Length + " caracteres)");
            Console.Read();
        }
    }
}
