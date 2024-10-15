using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor del lado del cuadrado: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("El perímetro del cuadrado es: "+l*4);
        }
    }
}
