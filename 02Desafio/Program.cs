using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string respostaApp = string.Empty;
            do
            {
                Console.WriteLine("|----------------------------------------------------------------------------------|");
                Console.WriteLine("\t\t\t\tINFORMAÇÃO TEMPORARIA!!! ");
                Console.Write("  Obs.: Tempo de chegada deve ser menor ou igual a 0, caso contrario está atrasado! ");
                Console.Write("\n  Para chegadas com antecedencia utilize \"-\" (-1,-2,-3), para pontualidades \"0\"\n  e  atrasos digitos positivos (1,2,3)");
                Console.WriteLine("\n|----------------------------------------------------------------------------------|");
                Console.Write("Ao fim da leitura, pressione ENTER!");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("|-------------------------------------------------------------------|");
                Console.Write("\tQuantos alunos precisam chegar a tempo: ");
                int alunosNecessarios = int.Parse(Console.ReadLine());
                Console.WriteLine("|-------------------------------------------------------------------|");


                
                var tempoDeChegada = Helper.ObterTempoDeChegada(alunosNecessarios);
                Helper.StatusAula(tempoDeChegada);
                Console.Write("\nDeseja resetar a aplicação? (s/n): ");
                respostaApp= Console.ReadLine();
                Console.Clear();
            } while (respostaApp.Equals("s"));
            
        }

       
    }
}
