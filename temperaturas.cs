using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[] temperaturas = new double[5]; //declarando e iniciando 


            Console.WriteLine("---- ingreso de temperaturas ----");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"ingrese la temperatura del dia {i + 1}:");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double tem in temperaturas)
            {
                suma += tem;
                if (tem > maxT) maxT = tem;
                if (tem < minT) minT = tem;
            }

            double promedio = suma / temperaturas.Length;

            //salida de informacion 
            Console.WriteLine("\n---reporte---");
            Console.WriteLine($"temperaturas registradas: { string.Join(",",temperaturas)}");
            Console.WriteLine($"temperatura promedio: {promedio:F2}°C");
            Console.WriteLine($"temperatura Maxima: {maxT}°C");
            Console.WriteLine($"temperatura minima: {minT}°C");
        }
    }
}
