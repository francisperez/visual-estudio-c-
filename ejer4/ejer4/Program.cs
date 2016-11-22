using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4. Expresiones Aritméticas: Realizar un programa que lea los valores de los dos datos enteros por pantalla.
//Mostrar el resultado de la división real y división entera por pantalla de la forma indicada en ejecución (Formato de salida de datos). Realizar el exponente y la raíz cuadrada. Mostrar según se muestra en ejecución.
//    ++++++ Ejecución del Progrma +++++++
//    Introduce el valor de la variable a = 9
//    Introduce el valor de la variable b = 2
//    La división real de: 9 y 2 es: 4,5
//    La división entera de: 9 y 2 es: 4
//    El exponente 9 ^ 2 es: 81
//    La raiz cuadrada de 9 es: 3

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, division, div_entera, exponente, raiz,raiz2;
            System.Console.WriteLine("++++++ Ejecución del Progrma +++++++");
            System.Console.WriteLine("introduce el valor de la variable a= ");
            num1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("introduce el valor de la variable b= ");
            num2 = Convert.ToDouble(Console.ReadLine());
            division = num1 / num2;
            System.Console.WriteLine("la division real de {0} y {1} es {2}",num1,num2,division);
            div_entera = num1 / num2;
            div_entera = Convert.ToInt32(div_entera);
            System.Console.WriteLine("la division entera de {0} y {1} es {2}", num1, num2, div_entera);
            exponente = Math.Pow(num1, num2);
            System.Console.WriteLine("el exopente de {0} elevado {1} es {2}", num1, num2, exponente);
            raiz = Math.Sqrt(num1);
            raiz2 = Math.Sqrt(num2);
            System.Console.WriteLine("la raiz de {0} es {1}", num1, raiz);
            System.Console.WriteLine("la raiz de {0} es {1}", num2, raiz2);


            System.Console.ReadKey();
        }
    }
}
