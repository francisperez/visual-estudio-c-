
//Se tiene la siguiente información:
//· Nombres de 4 operarios.
//· Ingresos en concepto de sueldo, cobrado por cada operario, en los últimos 3 meses.
//Realizar un programa para:
//Realizar el ingreso de la información mencionada. 
//Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada operario.
//Mostrar por pantalla el total pagado en sueldos a todos los operarios en los últimos 3 meses 
//Obtener el nombre del operario que tuvo el mayor ingreso acumulado
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Matriz
{
    class Matriz
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;

        public void Cargar()
        {
            empleados = new String[4];
            sueldos = new int[4, 3];
            for (int i = 0; i< empleados.Length; i++)
            {
                Console.Write("Ingrese el nombre del operario "+(i+1)+": ");
                empleados[i] = Console.ReadLine();
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    Console.Write("Ingrese sueldo " + (j + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[i, j] = int.Parse(linea);
                }
            }
        }
        public void CalcularSumaSueldos()
        {
            sueldostot = new int[4];
            for (int i = 0; i< sueldos.GetLength(0); i++)
            {
                int suma = 0;
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    suma = suma + sueldos[i, j];
                }
                sueldostot[i] = suma;
            }
        }
        public void ImprimirTotalPagado()
        {
            Console.WriteLine("Total de sueldos pagados por Operario.");
            for (int i = 0; i< sueldostot.Length; i++)
            {
                Console.WriteLine(empleados[i] + " - " + sueldostot[i]);
            }
        }
        public void EmpleadoMayorSueldo()
        {
            int may = sueldostot[0];
            string nom = empleados[0];
            for (int i = 0; i< sueldostot.Length; i++)
            {
                if (sueldostot[i] > may)
                {
                    may = sueldostot[i];
                    nom = empleados[i];
                }
            }
            Console.WriteLine("El operario con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
        }
        static void Main(string[] args)
        {
            Matriz ma = new Matriz();
            ma.Cargar();
            ma.CalcularSumaSueldos();
            ma.ImprimirTotalPagado();
            ma.EmpleadoMayorSueldo();
            Console.ReadKey();
        }
    }
}
