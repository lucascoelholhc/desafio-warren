using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Digite um valor inteiro, para ser o objetivo de soma: ");
                int objetivoSoma = int.Parse(Console.ReadLine());
                Console.Write("Digite uma sequência de 3 numeros, separados por virgula: ");
                var numeros = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------------");
                var retorno = Helper.ObterSequenciaDeSoma(objetivoSoma, numeros.ToArray());
                if (retorno.Count == 0 )
                {
                    Console.WriteLine("Valores abaixo do esperado!");
                }
                retorno.ForEach(x => Console.WriteLine($"[{x}]"));
                Console.ReadKey();
                Console.Write("\n Deseja resetar a aplicação? (s/n): ");
                result = Console.ReadLine();
            } while (result.Equals("s"));
          
        }
    }
}
