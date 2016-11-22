using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//13.	El personal de ventas recibe 200€ por semana más 9% de las ventas brutas de esa semana.
//Por ejemplo, una persona de ventas que vende 5000€ de productos químicos en una semana recibe 
//200€ más 9% de 5000€, o sea un total de 650€. Desarrolle un programa que introduzca las ventas brutas de cada vendedor 
//correspondiente a la última semana, y calcule y despliegue las ganancias de dicho vendedor. Procese las cifras vendedor
//por vendedor:
//    Introduzca ventas en euros (-1 para finalizar): 5000.00
//    Salario: 650.00
//    Introduzca ventas en euros (-1 para finalizar): 1234.56
//    Salario: 311.11
//    Introduzca ventas en euros (-1 para finalizar): 1088.89
//    Salario: 298.00
//    Introduzca ventas en euros (-1 para finalizar): -1

namespace ejer13
{
    class Program
    {
        static void Main(string[] args)
        {
            double i=0,salario;
            while(i!=-1){
                Console.WriteLine("Introduzca ventas en euros (-1 para finalizar): ");
                i = Convert.ToDouble(Console.ReadLine());
                salario = 200 + i * 0.09;
                Console.WriteLine("Salario: {0}",salario);
            }
            Console.WriteLine("fin del programa presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
