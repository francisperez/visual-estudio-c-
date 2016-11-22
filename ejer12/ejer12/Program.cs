using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//12.	Cuadrados&Cubos: Con lo visto hasta el momento, escribir un programa que calcule los cuadrados y los cubos de los 
//números del 1 al 10 y que los muestre del siguiente modo:
//numero	cuadrado	cubo
//1		1		1
//2		4		8	
//3		9		27
//4		16		64
//5		25		125
//6		36		216
//7		49		343


namespace ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuadrado;
            int cubo;
            Console.WriteLine("NUMERO  CUADRADO          CUBO");
            for (int i = 0; i < 10; i++) {
                cuadrado = i * i;
                cubo = i * i * i;
                Console.WriteLine("{0}           {1}             {2}",i,cuadrado,cubo);
            }
            Console.ReadKey();
        }
    }
}
