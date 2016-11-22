using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11.	Adivino: escribe un programa que pida a un jugador que introduzca un número entero cualquiera.
//El segundo jugador introducirá números intentando adivinar el valor que ha puesto el jugador 1. Tendrá 5 
//intentos para ello. El programa deberá dar pistas con cada uno de los intentos (indicando si es mayor o menor
//al valor del intento).

namespace ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,i;
            Console.WriteLine(" JUGADOR 1: Introduce el número que quieres que adivine ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (i = 6; i > 0; i--)
            {
                Console.WriteLine(" JUGADOR 2: prueba suerte con tu número: ");
                b = Convert.ToInt32(Console.ReadLine());
                if ((a > b) && (a != b))
                {
                    Console.WriteLine("tu número es mas pequeño");
                    Console.WriteLine("te quedan {0} intentos", i-1);
    

                }
                if ((a < b) && (a != b))
                {
                    Console.WriteLine("tu número es mas grande");
                    Console.WriteLine("te quedan {0} intentos", i-1);

                }
                if (i == 0)
                {
                    Console.WriteLine("¡ LO SIENTO, PERDISTE !");

                }
                if (a == b)
                {
                    Console.WriteLine("¡ LO ADIVINASTE !");
                    i = 0;
                }
                
            }

            Console.WriteLine("¡ FIN DEL JUEGO !");
            
            Console.ReadKey();
        }
    }
}
