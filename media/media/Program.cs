using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca 4 valores, devolveré la suma y el promedio: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int suma = a + b + c + d;
            int promedio = suma / 4;

            Console.WriteLine("La suma es: "+suma+" y el promedio es: "+promedio);
        }
    }
}
