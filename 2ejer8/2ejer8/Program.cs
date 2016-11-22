using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8.	Crear un programa que simule el juego de 3 en Raya.

namespace _2ejer8
{
    class Program
    {
         static void imprimir(char[,]matriz) {
            Console.WriteLine("   c c c");
            Console.WriteLine("   1 2 3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("f"+(i+1)+" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            char[,] tablero = new char[3,3];
            char circulo = 'O';
            char equis = 'X';
            char vacio = '-';
            bool terminar = false;
            int fila1, columna1, fila2, columna2, contador = 0;

            //rellenamos el tablero
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = vacio;
                }
            }
            Console.WriteLine("JUEGO 3 EN RAYA");
            Console.WriteLine("Realice tiradas válidas de 1 a 3 tanto para columna como para fila");
            imprimir(tablero);

            while (terminar==false)
            {
               do{
                Console.WriteLine("\njugador 1 realice su tirada:");
                Console.Write("fila:");
                fila1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("columna:");
                columna1 = Convert.ToInt32(Console.ReadLine());
                if((fila1 <= 0) || (fila1 >= 4)||(columna1 <= 0) || (columna1 >= 4))
                    Console.WriteLine("\nTirada erronea vuelva a tirar:");
               } while ((fila1 <= 0) || (fila1 >= 4)||(columna1 <= 0) || (columna1 >= 4));
                tablero[fila1-1, columna1-1] = circulo;
                imprimir(tablero);
                contador++;
               
                do
                {
                    Console.WriteLine("\njugador 2 realice su tirada:");
                    Console.Write("fila:");
                    fila2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("columna:");
                    columna2 = Convert.ToInt32(Console.ReadLine());
                    if ((fila2 <= 0) || (fila2 >= 4) || (columna2 <= 0) || (columna2 >= 4))
                        Console.WriteLine("\nTirada erronea vuelva a tirar:");
                } while ((fila2 <= 0) || (fila2 >= 4) || (columna2 <= 0) || (columna2 >= 4));
                tablero[fila2-1, columna2-1] = equis;
                imprimir(tablero);
                contador++;
                
                if ((tablero[0, 0] == tablero[0, 1]) && (tablero[0, 0] == tablero[0, 2]) && (tablero[0, 1] == tablero[0, 2]) && (tablero[0, 1] != vacio))//fila
                    terminar = true;
                if ((tablero[1, 0] == tablero[1, 1]) && (tablero[1, 0] == tablero[1, 2]) && (tablero[1, 1] == tablero[1, 2]) && (tablero[1, 1] != vacio))//fila
                    terminar = true;
                if ((tablero[2, 0] == tablero[2, 1]) && (tablero[2, 0] == tablero[2, 2]) && (tablero[2, 1] == tablero[2, 2]) && (tablero[2, 1] != vacio))//fila
                    terminar = true;
                if ((tablero[0, 0] == tablero[1, 0]) && (tablero[0, 0] == tablero[2, 0]) && (tablero[1, 0] == tablero[2, 0]) && (tablero[1, 0] != vacio))//columna
                    terminar = true;
                if ((tablero[0, 1] == tablero[1, 1]) && (tablero[0, 1] == tablero[2, 1]) && (tablero[1, 1] == tablero[2, 1]) && (tablero[1, 1] != vacio))//columna
                    terminar = true;
                if ((tablero[0, 2] == tablero[1, 2]) && (tablero[0, 2] == tablero[2, 2]) && (tablero[1, 2] == tablero[2, 2]) && (tablero[1, 2] != vacio))//columna
                    terminar = true;
                if ((tablero[0, 0] == tablero[1, 1]) && (tablero[0, 0] == tablero[2, 2]) && (tablero[1, 1] == tablero[2, 2]) && (tablero[1, 1] != vacio))//diagonal
                    terminar = true;
                if ((tablero[0, 2] == tablero[1, 1]) && (tablero[0, 2] == tablero[2, 0]) && (tablero[1, 1] == tablero[0, 2]) && (tablero[1, 1] != vacio))//diagonal
                    terminar = true;
                if (contador >= 9)//si se realizan las nueve tiradas
                    terminar = true;
            }

            Console.WriteLine("JUEGO TERMINADO");
           


            







            Console.ReadKey();
        }
    }
}
