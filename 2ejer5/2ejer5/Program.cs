using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.	Crear un programa que lea las notas de cada alumnos de una clase de 10 alumnos para 
//sus 4 asignaturas. se rellenará la matriz desde teclado y calculará la media que cada alumno tiene en el curso.

namespace _2ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[,] array = new int[10, 4];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Introduzca la nota de la materia {0} del alumno {1}: ",i+1,j+1);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    suma = suma + array[i, j];
                }
                suma = suma / 4;
                Console.WriteLine("la media del alumno {0} es: {1}", i + 1, suma);
                suma = 0;
            }
            Console.ReadKey();
        }
    }
}
