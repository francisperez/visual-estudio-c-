using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//17.	Select case: comprobador de fechas: hacer un programa que lea una fecha representada por dos enteros, mes y año y dé
//como resultado los días correspondientes del mes. Es decir: 	
//Mes(##):5
//Año (####): 2005
//El mes 5 del año 2005 tiene 31 días
   
//Tener en cuenta que febrero puede tener 28 o 29 días (si es bisiesto). Un año es bisiesto cuando es múltiplo de 4 y no de 100.
//O cuando es múltiplo de 400. Ej. el año 2000 no sería bisiesto según las dos primeras condiciones, pero sí lo es porque es
//múltiplo de 400. El año 2100 no es bisiesto. Aunque es múltiplo de 4, también lo es de 100 y no de 400.


namespace ejer17
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano,mes,dias=0;
           
            Console.WriteLine("Introduce el mes:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el año:");
            ano = Convert.ToInt32(Console.ReadLine());

            if (mes == 1) {
                dias = 31;
            }
            if (mes == 2)
            {
                if (((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0))
                    dias = 29;
                else
                    dias = 28;
            }
            if (mes == 3)
            {
                dias = 31;
            }
            if (mes == 4)
            {
                dias = 30;
            }
            if (mes == 5)
            {
                dias = 31;
            }
            if (mes == 6)
            {
                dias = 30;
            }
            if (mes == 7)
            {
                dias = 31;
            }
            if (mes == 8)
            {
                dias = 31;
            }
            if (mes == 9)
            {
                dias = 30;
            }
            if (mes == 10)
            {
                dias = 31;
            }
            if (mes == 11)
            {
                dias = 30;
            }
            if (mes == 12)
            {
                dias = 31;
            }
            Console.WriteLine("El mes {0} del año {1} tiene {2} días",mes,ano,dias);
            Console.ReadKey();
        }
    }
}
