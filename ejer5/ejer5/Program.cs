using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5. Pitágoras: Realizar un programa que calcule el valor de la hipotenusa de
//un triangulo rectángulo conocidas las longitudes de los lados de los catetos. 
//La entrada será la longitud de los dos catetos. La salida será mostrar por pantalla la longitud de la hipotenusa.

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1;
            double cateto2;
            double hipotenusa;

            System.Console.WriteLine("introduce el valor del cateto 1 = ");
            cateto1 = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("introduce el valor del cateto 2 = ");
            cateto2 = Convert.ToDouble(Console.ReadLine());
            hipotenusa = (cateto1 + cateto1) * (cateto2 + cateto2);
            System.Console.WriteLine("el valor de la hipotenusa es = {0}",hipotenusa);

            System.Console.ReadKey();
        }
    }
}
