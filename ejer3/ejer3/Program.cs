using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. Tipos de Datos: Realizar un programa en el que se definan variables de diferentes tipos de
//datos (Double, Single, Integer, char, string), asignar en el programa valores y mostrar por pantalla. 
//Utilizar operadores de concatenación para mostrar varios valores en la misma línea.

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero=25;
            double deci=2.8;
            string letras = "esto es un string";
            char letra = 'a';

            System.Console.WriteLine("entero {0}\n  decimal {1}\n  letra {2}\n  letras {3}\n ", entero, deci, letra, letras);
            System.Console.ReadKey();
        }
    }
}
