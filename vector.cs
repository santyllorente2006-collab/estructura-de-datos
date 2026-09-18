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
            Console.WriteLine($"Elemento en [0]: { numeros[0]}");

            string[] estudiantes =
                {"Santiago","Jaider","Daniela","Juan"};

            for (int i = 0; i < estudiantes.Length; i++) 
            {
                Console.WriteLine($"indice [{i}]: {estudiantes[i]}");
            }

        }
    }
}
