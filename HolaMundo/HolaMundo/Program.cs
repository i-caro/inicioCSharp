using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {

        static void menu()
        {
            Console.WriteLine("1. Sumar.");
            Console.WriteLine("2. Restar.");
            Console.WriteLine("3. Multiplicar.");
            Console.WriteLine("4. Dividir.");
            Console.WriteLine("5. Salir.");
        }

        static Boolean continuar()
        {
            Console.WriteLine("¿Desea realizar otra operación? (Y/N)");
            string salida = Console.ReadLine();
            if (salida.ToUpper().Equals("Y")){ 
                return false;
            }
            else if (salida.ToUpper().Equals("N")) {
                return true;
            }
            else
            {
               Console.WriteLine("Seleccione una opción válida.");
                continuar();
                return false;
            }
        }

        static void Main(string[] args)
        {
            Boolean salir = false;
            while (!salir)
            {
                Console.WriteLine("---Bienvenido a mi calculadora---");
            Console.WriteLine("Inserte el primer numero.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte el segundo numero.");
            int b = int.Parse(Console.ReadLine());
            Program.menu();
            Console.WriteLine("Seleccione una opción.");
            int opcion = int.Parse(Console.ReadLine());
            
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado de " + a + " sumado a " + b + " es: " + (a + b));
                        salir = Program.continuar();
                        break;
                    case 2:
                        Console.WriteLine("El resultado de " + a + " restado a " + b + " es: " + (a - b));
                        salir = Program.continuar();
                        break;
                    case 3:
                        Console.WriteLine("El resultado de " + a + " multiplicado por " + b + " es: " + (a * b));
                        salir = Program.continuar();
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine("Error. No se puede dividir entre 0.");
                            salir = true;
                        }
                        else
                        {
                            Console.WriteLine("El resultado de " + a + " dividido entre " + b + " es: " + (a / b));
                            salir = Program.continuar();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar mi programa.");
                        salir = true;
                        break;
                }

            }
            
        }
    }
}
