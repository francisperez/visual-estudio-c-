using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.	Rehacer el ejercicio 1 y añadir la siguiente funcionalidad: el programa  calculará el valor máximo 
//y el mínimo, así como la media aritmética de los valores del vector. Presentar los 3 datos por 
//pantalla como salida.

namespace _2ejer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementos = 0;
            int numero,mayor=0,menor=200,media=0;
            Console.WriteLine("Introduzca el numero de elementos del array: ");
            elementos = Convert.ToInt32(Console.ReadLine());   
            int[] array = new int[elementos];

            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine("Introduzca un numero: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine("m({0})= m{1}", i, array[i]);
            }

            for (int i = 0; i < elementos; i++)
            {
                media = array[i] + media;
                numero = array[i];
                if (numero > mayor)
                    mayor = numero;
                if (numero < menor)
                    menor = numero;
            }
            media = media / elementos;
            Console.WriteLine("el mayor de los numeros del vector es: "+mayor);
            Console.WriteLine("el menor de los numeros del vector es: " + menor);
            Console.WriteLine("la media de los numeros introducidos es : " + media);


            Console.ReadKey();
        }
    }
}
