using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1004
{
    class Program
    {
        // 4) Escribir un método que acepte dos catetos y devuelve la hipotenusa (usar la clase Math para calcular la raíz cuadrada)

        static void Main(string[] args)
        {
            Console.Write("Introduzca el primer cateto: ");
            float cateto1 = float.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo cateto: ");
            float cateto2 = float.Parse(Console.ReadLine());

            double hipotenusa = CalcularHipotenusa(cateto1, cateto2);
            Console.WriteLine("La hiponetusa es: " + hipotenusa);
            Console.Read();
        }

        /// <summary>
        /// Calcula la hipotenusa de un triángulo a partir de sus catetos
        /// </summary>
        /// <param name="cateto1">Primer cateto</param>
        /// <param name="cateto2">Segundo cateto</param>
        /// <returns></returns>
        static double CalcularHipotenusa(float cateto1, float cateto2)
        {
            return Math.Sqrt(Math.Pow(cateto1,2) + Math.Pow(cateto2, 2));
        }
    }
}
