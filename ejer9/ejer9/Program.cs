using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//programa que dados dos numeros introducidos por el usuario te calcula su máximo 
//común divisor  entre ellos

namespace ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Introduce dos números para hallar su M.C.D ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int resto;
            resto = a % b;

            while (resto != 0)
            {
                a = b;
                b = resto;
                resto = a % b;
            }

            Console.WriteLine("El máximo común divisor es {0}",b);
            Console.ReadKey();
            

        }
    }
}
