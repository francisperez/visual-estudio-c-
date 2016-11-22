using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//15.	Tabla de multiplicar: Escribir un programa que solicite un valor entero positivo
//entre 1 y 10 y muestre la tabla de multiplicar para dicho número.

namespace ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, resultado;
            Console.WriteLine("Introduce un valor entero entre 1 y 10");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < 10; i++) {
                resultado = a * i;
                Console.WriteLine("{0} x {1} = {2}",a,i,resultado);
            }
            Console.ReadKey();
        }
    }
}
