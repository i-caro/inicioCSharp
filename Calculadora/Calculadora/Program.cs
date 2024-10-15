using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void menu()
        {
            Console.WriteLine("1. Valor absoluto.");
            Console.WriteLine("2. Potencial al cubo.");
            Console.WriteLine("3. Raíz cuadrada");
            Console.WriteLine("4. Seno");
            Console.WriteLine("5. Coseno");
            Console.WriteLine("7. Máximo");
            Console.WriteLine("8. Mínimo");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número: ");
            int a = int.Parse(Console.ReadLine());
            menu();
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine(Math.Abs(a));
                    break;
                case 2:
                    Console.WriteLine(a*a);
                    break;
                case 3:
                    Console.WriteLine(Math.Sqrt(a));
                    break;
                case 4:
                    Console.WriteLine(Math.Sin(a));
                    break; 
                case 5:
                    Console.WriteLine(Math.Cos(a)); 
                    break;
                case 6:
                    Console.WriteLine("Introduzca el segundo valor.");
                    int b = int.Parse(Console.ReadLine());  
                    Console.WriteLine(Math.Max(a, b));
                    break;
                case 7:
                    Console.WriteLine("Introduzca el segundo valor.");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Min(a, c));
                    break;
            }
        }
    }
}
