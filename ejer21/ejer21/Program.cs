
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//21.	Ajedrez: Imprimir un tablero de ajedrez en pantalla, las casillas blancas se simbolizan con una B
//y las negras con N (8x8). El programa mostrará * en las casillas a las que se pueda mover un alfil desde una posición dada.

namespace ejer22
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila, columna, fila_alfil, columna_alfil;

            for (fila = 1; fila <= 8; fila++)
            {
                for (columna = 1; columna <= 8; columna++) 
                {
                    if (fila % 2 != 0)
                    {
                        if (columna % 2 != 0)
                        {
                            Console.Write(" N ");//(fila impar,columna impar)         
                        }
                        else
                        {
                            Console.Write(" B "); //(fila impar,columna par)
                        }
                    }
                    else
                    {
                        if (columna % 2 != 0)
                        {
                            Console.Write(" B ");//(fila par,columna impar)
                        }
                        else
                        {
                            Console.Write(" N ");//(fila par,columna par)
                        }
                    }
                   
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n Introduce el número de columana y fila donde va a ir el alfil");
            Console.WriteLine("columnna:");
            columna_alfil = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("fila:");
            fila_alfil = Convert.ToInt32(Console.ReadLine());
            char alfil='*';

            for (fila = 1; fila <= 8; fila++)
            {
                for (columna = 1; columna <= 8; columna++)
                {
                    if ((fila == fila_alfil) && (columna == columna_alfil))
                        Console.Write(" {0} ",alfil);
                    if (fila % 2 != 0)
                    {
                        if (columna % 2 != 0)
                        {
                            Console.Write(" N ");//(fila impar,columna impar)         
                        }
                        else
                        {
                            Console.Write(" B "); //(fila impar,columna par)
                        }
                    }
                    else
                    {
                        if (columna % 2 != 0)
                        {
                            Console.Write(" B ");//(fila par,columna impar)
                        }
                        else
                        {
                            Console.Write(" N ");//(fila par,columna par)
                        }
                    }

                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}
