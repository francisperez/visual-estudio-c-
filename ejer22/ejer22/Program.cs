using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Programa que te imprime todas las fichas del dominó sin repetirlas*/
namespace ejer22
{
    class Program
    {
        static void Main(string[] args)
        {
          int i,j=0,ficha=0;


          for (i = 0; i <= 6; i++)
          {
              Console.WriteLine(""); //salto de linea

              for (j = 0; j <= 6; j++)
              
                  if (i >= j)
                  { //si i es mayor o igual que j, que no repita los valores de i y j
                      ficha++; //contador de fichas
                      Console.WriteLine(" | {0} : {1} |", i, j);
                  }
              
          }
           
            Console.ReadKey();
        }
    }
}
