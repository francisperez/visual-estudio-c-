using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Aritmética: Realizar un programa que realice la suma, resta y multiplicación de dos valores enteros que se
//definan en el propio programa.

namespace ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1=8;
            int numero2=4;
            int suma, resta, multiplicacion, division;
            suma=numero1+numero2;
            resta=numero1-numero2;
            multiplicacion=numero1*numero2;
            division=numero1/numero2;

            System.Console.WriteLine("suma {0} resta {1} multiplicacion {2} division {3}", suma,resta,multiplicacion,division);
            System.Console.ReadKey();
           
        }
    }
}
