using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//7. Horas: Dada una expresión en horas, minutos y segundos con valores arbitrarios, 
//diseñar un algoritmo que nos transforme la expresión dada en una expresión correcta, 
//es decir, horas, minutos y segundos dentro de su rango correspondiente. Los valores se piden al usuario.
//Ejemplo para la entrada: 75 horas, 81 min, 91 segundos, la salida deberá ser: 
//3 días, 4 horas, 22 minutos, 31 segundos.

namespace ejer7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, horas, minutos, segundos, tran_sengundos;
            int dias_auxiliar;

            System.Console.WriteLine("introduce el valor de la horas = ");
            horas = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("introduce el valor de los minutos = ");
            minutos = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("introduce el valor de los segundos = ");
            segundos = Convert.ToInt32(Console.ReadLine());

           //transformamos todo a segundos
            tran_sengundos = (segundos) + (minutos * 60) + (horas * 3600);
            dias = tran_sengundos / 86400;
            horas = tran_sengundos  / 3600;
            minutos =((tran_sengundos - horas * 3600) / 60);
            segundos = tran_sengundos - (horas * 3600 + minutos * 60);

            dias_auxiliar = horas / 24;

            System.Console.WriteLine("\n\nvalor de los dias = {0}", dias_auxiliar);
            System.Console.WriteLine("valor de las horas = {0} ", horas);
            System.Console.WriteLine("valor de los miunutos = {0} ", minutos);
            System.Console.WriteLine("valor de los segundos = {0} ", segundos);

           


            System.Console.ReadKey();
        }
    }
}
