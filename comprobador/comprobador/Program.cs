using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comprobador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca cualquier cosa: ");
            string a = Console.ReadLine();

            Console.WriteLine(a.StartsWith("www"));
        }
    }
}
