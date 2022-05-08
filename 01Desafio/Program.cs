using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = string.Empty;
            do
            {
               
                Console.Clear();
                Console.WriteLine("-------------------------------------------------------------------");
                Console.Write("Digite um número limite (n) para visualizar a reversão: ");
                int limite = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------");
                string aux = Helper.RealizarOperação(limite);
                Console.WriteLine(aux);
                Console.Write("\n Pressione Enter para continuar..."); Console.ReadKey(); 
                Console.Write("\n Deseja resetar a aplicação? (s/n): ");
                result = Console.ReadLine();

            } while (result.Equals("s"));
            
        }
    }
}
