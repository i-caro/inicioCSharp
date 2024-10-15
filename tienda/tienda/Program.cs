using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la cantidad del producto :");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("El total es de: "+precio*cantidad+"€");
        }
    }
}
