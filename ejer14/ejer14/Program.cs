using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Uso de funciones: hacer un programa donde se definan una función que calcule la suma de dos enteros
//y un procedimiento que muestre una cadena de caracteres. Desde el principal deberá llamarse a la función suma 
//y al procedimiento muestra que muestra el resultado.

namespace ejer14
{
    class Program
    {
       public static int Suma(int a, int b)
        {
            int resultado;
            resultado = a + b;
            return resultado;
        }

        public static void Imprimir(int suma)
        {   
            Console.WriteLine("La suma de los numero es {0}",suma);
        }

        static void Main(string[] args)
        {
            int numero1 = 35;
            int numero2 = 15;
            Imprimir(Suma(numero1, numero2));
            Console.ReadKey();
        }
    }
}
