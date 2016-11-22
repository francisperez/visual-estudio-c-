using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.	Realizar un programa que pinte en pantalla un tablero de ajedrez de 8x8 representando las casillas
//blancas con una B y las negras con una N. El tablero se almacenará en una matriz que se
//mostrará en pantalla. Pedir al usuario la posición de un alfil en el 
//tablero y mostrar sus posibles movimientos en el tablero.

namespace _2ejer7
{
    class Program
    {
        static void imprimir(char[,] matriz)
        {
            Console.WriteLine("    c c c c c c c c");
            Console.WriteLine("    1 2 3 4 5 6 7 8\n");
            for (int i = 1; i <= 8; i++)
            {
                Console.Write("f" + i + "  ");
                for (int j = 1; j <= 8; j++)
                {
                    Console.Write(matriz[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int fila, columna;
            char blancas = 'B';
            char negras = 'N';
            char alfil = '*';
            char[,] tablero= new char[9,9];

            for (int i = 1; i <= 8; i++) //rellenamos la matriz con blancas y negras
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (i % 2 != 0)
                    {
                        if (j % 2 != 0)
                            tablero[i, j] = negras;
                        
                        else
                            tablero[i, j] = blancas;     
                    }
                    else
                    {
                        if (j % 2 != 0)
                            tablero[i, j] = blancas;
                        else
                            tablero[i, j] = negras;
                    }

                }
              
            }

            imprimir(tablero);
            Console.WriteLine("\n\nintroduce la posicion del alfil:");
            Console.WriteLine("fila:");
            fila = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("columna:");
            columna = Convert.ToInt32(Console.ReadLine());

            tablero[fila, columna] = alfil;
            imprimir(tablero);

            for (int i = 1; i <= tablero.GetLength(100); i++)
            {
                for (int j = 1; j <= tablero.GetLength(100); j++)
                {
                    tablero[fila + i, columna + i] = alfil;
                    //tablero[fila - i, columna - i] = alfil;
                    //tablero[fila - i, columna + i] = alfil;
                    //tablero[fila + i, columna - i] = alfil;
                    
                }
            }

            Console.WriteLine("\n\nposibles movimientos del alfil:");
            imprimir(tablero);



            Console.ReadKey();
        }
    }

}