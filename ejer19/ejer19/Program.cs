
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//19.   Tarot: realiza un programa que pedirá al usuario el día, mes y año de su nacimiento.
//Comprobará que son valores válidos. En caso de no serlo, volverá a pedir dicho dato. Posteriormente calculará el
//número del tarot. Este se calcula del siguiente modo: Para la entrada:
//Día: 17
//Mes: 10
//Año: 1970
//17+10+1970 =1997 => 1+9+9+7=26=>2+6=8
//El número del tarot es el 8.


namespace ejer19
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = 0, mes, ano, suma, suerte1 = 0, suerte2 = 0;
            bool condicion = false;
            do
            {
                Console.WriteLine("Por favor introduzca valores válidos de dia, mes y año de nacimiento");
                Console.WriteLine("Introduce tu dia de nacimiento: ");
                dia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce tu mes de nacimiento: ");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce tu año de nacimiento: ");
                ano = Convert.ToInt32(Console.ReadLine());
                condicion = ((dia > 0) && (dia < 31) && (mes > 0) && (mes < 12) && (ano > 1900) && (ano < 2016));
            } while (condicion == false);

            suma = dia + mes + ano;
            while (suma > 0)
            {
                suerte1 += suma % 10;
                suma = suma / 10;
            }
            while (suerte1 > 0)
            {
                suerte2 += suerte1 % 10;
                suerte1 = suerte1 / 10;
            }
            Console.WriteLine("Tu número de la suerte es: " + suerte2);



            Console.WriteLine("presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}