using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Crear un programa con una matriz unidimensional con nelem elementos de tipo entero. nelem será un valor
//pedido al usuario por entrada estándar. Rellenar la matriz con datos introducidos por el usuario. Finalmente mostrar
//los resultados.
//Prestar especial atención a la forma de mostrar los datos y de introducirlos.
//Por ejemplo, "m(0)=" en lugar de "Introduce un valor:"


namespace _2ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementos=0;
            Console.WriteLine("Introduzca el numero de elementos del array: ");
            elementos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(elementos);
            int[] array = new int[elementos];

            for (int i = 0; i < elementos; i++) {
                Console.WriteLine("Introduzca un numero: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < elementos; i++)
            {
                Console.WriteLine("m({0})= m{1}",i,array[i]);
            }

            Console.ReadKey();
        
        }

    }
}
