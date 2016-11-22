using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//4.	Realizar un programa que pida al usuario que rellene una matriz 3x4. El programa calculará la suma
//de los valores de cada fila y los mostrará por pantalla.

namespace _2ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[,] array = new int[3,4];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Introduzca un numero en la matriz: ");
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma = suma + array[i, j];
                }
            Console.WriteLine("la suma de la fila {0} es: {1}", i+1, suma);
            suma = 0;
            }
            Console.ReadKey();
        }
    }
}
