using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10.	Par e Impar: crea un programa que lea un valor por teclado. En la primera versión: que muestre un mensaje
//por pantalla indicando si es par. Modifica el programa para que muestre un mensaje indicando si es par o impar
namespace ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Introduce un número para saber si es par o impar ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("El número introducido es par");
            }
            else {
                Console.WriteLine("El número introducido es impar");
            }
            Console.ReadKey();
        }
    }
}
