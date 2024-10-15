using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para calcular la nota utilizaremos 4 calificaciones.");
            Console.WriteLine("La dos primeras son los parciales (50%): ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("La tercera es el exámen (30%): ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("La cuarta el trabajo final (20%): ");
            double nota4 = double.Parse(Console.ReadLine());

            double nota_1 = (nota1 + nota2)/4;
            double nota_2 = nota3*0.3;
            double nota_3 = nota4 * 0.2;

            Console.WriteLine("La nota final del alumno es: "+(nota_1 + nota_2 + nota_3));


        }
    }
}
