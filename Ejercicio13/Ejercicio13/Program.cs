using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la primera frase: ");
            string frase = Console.ReadLine();
            Console.Write("Ingrese la segunda frase: ");
            if(frase.Length == Console.ReadLine().Length)
            {
                Console.Write("Las frases tienen la misma longitud");
            }
            else
            {
                Console.Write("Las frases tienen diferente longitud");
            }
            Console.ReadKey();
        }
    }
}
