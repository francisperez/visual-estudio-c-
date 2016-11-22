using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Ganancias: Para sacar al mercado un nuevo producto, intervienen 4 personas:
//una que lo diseña y 3 que lo fabrican. Diseñar un programa que calcule cuánto 
//cobra cada uno de ellos sabiendo que el diseñador cobra doble que los fabricantes. 
//Entrada: Precio de venta del producto. Salida: Ganancias del Diseñador y los fabricantes.

namespace ejer6
{
    class Program
    {
        static void Main(string[] args)
        {
            double disenador, fabricante1, producto;


            System.Console.WriteLine("introduce el valor del producto = ");
            producto = Convert.ToDouble(Console.ReadLine());
            fabricante1 = producto / 5;
            disenador = fabricante1+fabricante1;

            System.Console.WriteLine("el diseñador gana = {0}",disenador);
            System.Console.WriteLine("el fabricante 1 gana = {0}",fabricante1);
            System.Console.WriteLine("el fabricante 2 gana = {0}",fabricante1);
            System.Console.WriteLine("el fabricante 3 gana = {0}",fabricante1);


            System.Console.ReadKey();



        }
    }
}
