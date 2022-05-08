using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Desafio
{
    public class Helper
    {
        public static void StatusAula(List<int> tempoDeChegada)
        {
            if (tempoDeChegada.Count(x => x <= 0) == tempoDeChegada.Count())
            {
                Console.Clear();
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine("\t\tAULA NORMAL!");
                Console.WriteLine("|--------------------------------------------------|");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("|--------------------------------------------------|");
                Console.WriteLine("\t\tAULA CANCELADA.");
                Console.WriteLine("|--------------------------------------------------|");
            }
        }

        public static List<int> ObterTempoDeChegada(int alunosNecessarios)
        {
            int i = 1;
            var tempoDeChegadas = new List<int>(alunosNecessarios);
            while (i <= alunosNecessarios)
            {
                Console.Write($"*Aluno {i}:");
                tempoDeChegadas.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine();
                i++;
            }
            return tempoDeChegadas;
        }
    }
}
