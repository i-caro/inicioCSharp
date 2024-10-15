using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuatroNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 4 números, calculare la suma de los dos primeros y el producto de los dos últimos: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); 
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b + " y " + c * d);
        }
    }
}
