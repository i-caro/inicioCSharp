using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pburger = 10;
            int ppapas = 5;
            int pbebidas = 3;

            Console.WriteLine("Introduzca la cantidad de hamburguesas consumidas: ");
            int burger = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad de papas consumidas: ");
            int papas = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad de bebidas consumidas: ");
            int bebidas = int.Parse(Console.ReadLine());

            int total = (burger*pburger)+(papas*ppapas)+(pbebidas*bebidas);

            Console.WriteLine("El total a pagar es: " + total);
        }
    }
}
