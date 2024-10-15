using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la participación de cada uno de los 3 socios en porcentaje: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"La participación del socio 1 es: {a}%, del 2: {b}%, del 3: {c}%");
        }
    }
}
