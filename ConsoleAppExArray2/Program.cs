using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[3];

            Console.WriteLine("Digite o primeiro nome: ");
            nome[0] = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome: ");
            nome[1] = Console.ReadLine();
            Console.WriteLine("Digite o terceiro nome: ");
            nome[2] = Console.ReadLine();


            Console.WriteLine("Primeiro nome: " + nome[0]);
            Console.WriteLine("Segundo nome: " + nome[1]);
            Console.WriteLine("Terceiro nome: " + nome[2]);

            Console.ReadKey();
        }
    }
}
