using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6.	Se desea realizar un histograma con los pesos de los alumnos de un determinado curso.
//El programa pedirá el número de alumnos del curso y luego el usuario rellenará los valores de los pesos 
//de los alumnos. Realizar un programa que lea los pesos e imprima el histograma. Suponer que los pesos válidos están 
//comprendidos entre 10 y 100 kg. 
//En el histograma solo aparecerán los pesos que se corresponden con uno o más alumnos. Por ejemplo:
//peso    num alumnos
//50      **
//51      *****
//52      ***
//El número de asteriscos se corresponde con el número de alumnos del espeso especificado.


namespace _2ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            int alumnos = 0, peso=0;
            int[] array = new int[500]; //dejamos vector de sobra aunque despues solo utilicemos las utiles que serán alumnos
            Console.WriteLine("Introduzca el numero de alumnos que tiene el curso ");
            Console.WriteLine("El peso de los alumnos debe de ser mayor que 10 y menor que 100 ");
            alumnos= Convert.ToInt32(Console.ReadLine());
            


            for (int i = 0; i < alumnos; i++)
            {
               Console.WriteLine("Introduzca el peso del alumno ");
               peso=Convert.ToInt32(Console.ReadLine());
               if ((peso > 100) || (peso < 10)) 
               {
                   Console.WriteLine("Introduzca el peso del alumno correctamente");
                   i--; //decrecemos la i para que el error en la introducción de datos no afecte al bucle
               }else
               array[i] = peso;
            }

            // Utilizo el metodo de ordenacion de la burbuja para ordenar de menor a mayor
            for (int i = 0; i < alumnos - 1; i++)
            {
                for (int j = i + 1; j < alumnos; j++)
                {
                    if (array[j] < array[i])
                    {
                        peso = array[j];
                        array[j] = array[i];                         
                        array[i] = peso;
                    }
                }
            }

            array[alumnos]=0;
            Console.WriteLine("PESO   NUMERO DE ALUMNOS ");

            for (int i=0; i < alumnos; i++)
            {
              if (array[i]!=array[i+1])
              {
                  Console.Write("\n "+array[i]);
                  Console.Write("      ");  
   
                   for (int j=0; j<alumnos; j++)
                   {
                        if (array[j]==array[i])
                            Console.Write("*");                                         
                   }
              }    
            } 

            Console.ReadKey();
        }
    }
}
