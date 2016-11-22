using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//18.	Suma múltiplos: Escribe un programa que dado dos valores enteros a y b, introducidos por el usuario
//, muestre la suma de los múltiplos de 5 comprendidos entre a y b. Si a es mayor que b, debe intercambiar
//ambos valores. Además el programa comprobará que los valores no sean negativos. En caso de serlo, avisará al
//usuario y cambiará el signo de dichos valores. 
namespace ejer18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,multiplo=0,contador=0,auxiliar;
            int i = 0;

            Console.WriteLine("Introduce el valor 1:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el valor 2:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                auxiliar = b;
                b = a;
                a = auxiliar;
            }  

                for (i = a; i <= b; i++) {
                   
                    if ((i % 10 == 0) || (i % 10 == 5) || (i == 5) || (i == 0))
                    {
                        contador++;
                        multiplo= i + multiplo;
                    }
                }
            
            Console.WriteLine("Los multiplos de 5 que hay son: {0}",contador);
            Console.WriteLine("El valor de los multiplos sumados es: {0}",multiplo);
            Console.ReadKey();

        }
    }
}
