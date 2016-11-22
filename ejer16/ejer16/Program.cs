using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//16.	Cifras: Programa que se le pase un valor entero y positivo, y diga cuantas cifras 
//son el número 7. Ejemplo entrada: 2473771 salida: 3.

namespace ejer16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,cifras=0;
            Console.WriteLine("Introduce un numero entero y positivo");
            a = Convert.ToInt32(Console.ReadLine());
           
            while (a != 0)//mientras a n le queden cifras
            {             
                a = a / 10; //le quitamos el último dígito
                cifras ++;  //sumamos 1 al contador de cifras
            }
            Console.WriteLine("El numero de cifras que tiene el numero introducido es : {0}",cifras);
            Console.ReadKey();
        }
    }
}
