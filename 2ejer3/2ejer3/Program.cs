using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ejer3
{
    class Program
    {
        static int Mayor(int []array,int elementos) { 
            int mayor=0;
            int numero = 0;
            for (int i = 0; i < elementos; i++)
            {
                numero = array[i];
                if (numero > mayor)
                    mayor = numero;
            }   
            return mayor;
        }

        static int Menor(int[] array, int elementos)
        {
            int menor = 5000;
            int numero = 0;
            for (int i = 0; i < elementos; i++)
            {
                numero = array[i];
                if (numero < menor)
                    menor = numero;
            }
            return menor;
        }

        static int Media(int[] array, int elementos)
        {
            int media = 0;
            for (int i = 0; i < elementos; i++)
            {
                media = array[i] + media;
            }
            media = media / elementos;
            return media;
        }

        static void Main(string[] args)
        {
            int elementos = 0;
            int numero, mayor = 0, menor = 200, media = 0;
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

            mayor = Mayor(array,elementos);
            Console.WriteLine("el mayor de los numeros del vector es: " + mayor);
            menor = Menor(array, elementos);
            Console.WriteLine("el menor de los numeros del vector es: " + menor);
            media = Media(array, elementos);
            Console.WriteLine("la media de los numeros del vector es: " + media);


            Console.ReadKey();
        }
    }
}
