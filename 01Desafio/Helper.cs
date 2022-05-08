using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Desafio
{
    public class Helper
    {
        public static int ReverterNum(int input)
        {
            var numeros = input.ToString().ToArray();
            if (numeros.Length > 2 && input.ToString().Contains("0"))
            {

            }
            int tamanho = numeros.Length;
            string retorno = string.Empty;
            for (int i = tamanho - 1; i >= 0; i--)
            {
                retorno += numeros[i].ToString();
            }

            return int.Parse(retorno);
        }
        public static bool IsReversivel(int num1, int reverso)
        {
            if (num1.ToString().Length == reverso.ToString().Length)
            {
                return true;
                //return num1 - reverso == 0 ? false : true;
            }
            else
            {
                return false;
            }

        }
        public static bool SomaIsImpar(int num1, int num2)
        {
            //a soma de n + reverso(n) resultem em números ímpares que estão abaixo de 1 milhão
            int result = num1 + num2;
            if (result < 1000000)
            {
                return result % 2 == 0 ? false : true;
            }
            else
            {
                //Retorna false pois a soma dos numeros, não está abaixo do limitador
                return false;
            }

        }

        public static string RealizarOperação(int limite)
        {
            string apresentarNumerosImpares = string.Empty;
            for (int i = 1; i < limite; i++)
            {
                int reverso = ReverterNum(i);
                if (IsReversivel(i, reverso))

                {
                    if (Helper.SomaIsImpar(i, reverso))
                    {
                        apresentarNumerosImpares += $" N:|{i}| Reverso(N): |{reverso}| SOMA:|{i + reverso}| \n";
                    }
                }
            }
            return apresentarNumerosImpares;
        }
        
    }
}

