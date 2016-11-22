using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//20.	 Números Aleatorios: El usuario introduce un numero entero.
//El programa tiene que mostrar por pantalla todos los enteros comprendidos entre 0 y el 
//número que introduzca el usuario de forma aleatoria y sin repetir ningún número.
//Ejemplo de ejecución: Si el usuario introduce un 5, 
//el programa debe mostrar en pantalla como resultado 3 4 1 2 5

namespace ejer20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            Random random = new Random();
            Console.WriteLine("Introduce el numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            int entero_auxiliar = numero;
            int j = numero;
            int[] numeros = new int[numero];
            int[] numeros_aleatorios = new int[numero];

            for (int i = 0; i < numero; i++)
            {
                numeros[i] = i + 1;
            }

            Console.WriteLine("Este el numero descompuesto ordenado: ");
            for (int i = 0; i < numero; i++)
            {
                Console.Write(" ");
                Console.Write(numeros[i]);
            }
//desordenamos el vector
            for (int i = 0; i < numero; i++)
            {
                entero_auxiliar = random.Next(0,j);
                numeros_aleatorios[i] = numeros[entero_auxiliar];
                numeros[entero_auxiliar] = numeros[j - 1];
                j--;
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Este el numero descompuesto desordenado: ");
            for (int i = 0; i < numero; i++)
            {
                Console.Write(" ");
                Console.Write(numeros_aleatorios[i]);
            }


            Console.ReadKey(); 
        }
    }
}
