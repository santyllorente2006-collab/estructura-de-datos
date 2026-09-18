using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]
                { 25, 43, 89, 90, 99 };
            Console.WriteLine($"Elemento en [0]: {numeros[0]}");

            string[] estudiantes =
                {"Santiago","Jaider","Daniela","Juan"};

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"indice [{i}]: {estudiantes[i]}");
            }

            //una tienda registra las ventas de 10 dias en un array double[]
            //calcular
            //1.calcular total vendido
            //2.promedio diario
            //3.encontrar dia con mayor venta
            //4.dia con menor venta
            //5.contar cuantos dias superaron al promedio

            double[] ventas = { 200.000, 302.000, 350.000, 120.822, 150.175, 600.008, 470.000, 100.555, 900.999 };
            double total = 0;
            double mayorVenta = ventas[0];
            double menorVenta = ventas[0];
            int diaMayorVenta = 0;
            int diaMenorVenta = 0;


            for (int i = 0; i < ventas.Length; i++){
                total += ventas[i];

                //i = 0
                //ventas[i] = 200.000
                //total = 200.000

                //i = 1
                //ventas[i] =302.000
                //total = 502.000

                if (ventas[i] > mayorVenta)
                {
                    mayorVenta += ventas[i];
                    diaMayorVenta = i;
                }
                if (ventas[i] > menorVenta) 
                {
                    menorVenta = ventas[i];
                    diaMenorVenta = i;
                }
            }   

            double promedio = total / ventas.Length;
            int diasSobrePromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
            { 
              if (ventas[i]> promedio)
              {
                diasSobrePromedio++;
              }
            }
            Console.WriteLine("REPORTE DE VENTAS");
            Console.WriteLine();

            Console.WriteLine($"Total vendido: ${total}");
            Console.WriteLine($"Promedio diario: ${promedio}");
            Console.WriteLine();

            Console.WriteLine($"Mayor venta: ${mayorVenta} - el dia {diaMayorVenta + 1}");
            Console.WriteLine($"Menor venta: ${menorVenta} - el dia {diaMenorVenta + 1}");

            Console.WriteLine($"Dias que superaro el promedio de ventas: ${diasSobrePromedio}");
            Console.WriteLine();

            Console.WriteLine("Ventas por dias");
            for (int i = 0;i < ventas.Length; i++) 
            {
              Console.WriteLine($"Dia {i + 1}: ${ventas[i]:F3}");
            }
        }
    }
}
