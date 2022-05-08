using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Desafio
{
    public class Helper
    {
        public static List<string> ObterSequenciaDeSoma(int objetivoSoma, char[] array)
        {
            string digitos = string.Empty;
            var numbers = new List<int>(array.Length);
            var listRetornoGenerico = new List<string>();
            var listRetornoUnico = new List<string>();
            int maiorNum = 0;
            int menorNum = 0;
            foreach (var x in array)
            {

                if (int.TryParse(x.ToString(), out int n))
                {
                    digitos += n.ToString();
                }
                else
                {
                    numbers.Add(int.Parse(digitos));
                    digitos = string.Empty;
                }
            }
            if (digitos != string.Empty)
            {
                numbers.Add(int.Parse(digitos));
            }
            if (numbers.Sum() == objetivoSoma)
            {
                listRetornoGenerico.Add(array.ToString());
            }
            foreach (var x in numbers)
            {

                if (maiorNum == 0 && menorNum == 0)
                {
                    maiorNum = numbers.Max();
                    menorNum = numbers.Min();
                }

                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers.Count > 2)
                    {
                        for (int j = i + 1; j < numbers.Count; j++)
                        {
                            if ((x + numbers[i] + numbers[j]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{numbers[i]},{numbers[j]}");
                            }
                            if ((x + numbers[i] + numbers[j] + numbers[j]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{numbers[i]},{numbers[j]},{numbers[j]}");
                            }
                            if ((x + x + x + numbers[i] + numbers[j]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{x},{x},{numbers[i]},{numbers[j]}");
                            }
                            if ((x + x + x + numbers[j] + numbers[j]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{x},{x},{numbers[j]},{numbers[j]}");

                            }
                            if ((x + x + x + numbers[i] + numbers[i]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{x},{x},{numbers[i]},{numbers[i]}");
                            }
                            if ((x + x + numbers[i] + numbers[i] + numbers[i]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{x},{numbers[i]},{numbers[i]},{numbers[i]}");
                            }
                            if ((x + numbers[j] + numbers[i] + numbers[i] + numbers[i]) == objetivoSoma)
                            {
                                listRetornoUnico.Add($"{x},{numbers[j]},{numbers[i]},{numbers[i]},{numbers[i]}");
                            }
                        }
                    }
                    if ((x + x + x + x + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{x},{x},{x},{numbers[i]}");
                    }

                    if ((x + x + numbers[i] + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{x},{numbers[i]},{numbers[i]}");
                    }
                    else if ((x + x + numbers[i] + numbers[i] + 1) == objetivoSoma)
                    {
                        if (numbers.Any(a => a + (x + x + numbers[i] + numbers[i]) == objetivoSoma))
                        {
                            int z = numbers.First(v => v + (x + x + numbers[i] + numbers[i]) == objetivoSoma);
                            listRetornoUnico.Add($"{x},{x},{numbers[i]},{numbers[i]},{z}");
                        }
                        else
                        {
                            listRetornoGenerico.Add($"{x},{x},{numbers[i]},{numbers[i]}");
                        }

                    }
                    else if ((x + x + numbers[i] + numbers[i] + 2) == objetivoSoma)
                    {
                        if (numbers.Any(a => a + (x + x + numbers[i] + numbers[i]) == objetivoSoma))
                        {
                            int z = numbers.First(v => v + (x + x + numbers[i] + numbers[i]) == objetivoSoma);
                            listRetornoUnico.Add($"{x},{x},{numbers[i]},{numbers[i]},{z}");
                        }
                        else
                        {
                            listRetornoGenerico.Add($"{x},{x},{numbers[i]},{numbers[i]}");
                        }

                    }

                    if ((x + x + x + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{x},{x},{numbers[i]}");
                    }
                    else if ((x + x + x + numbers[i] + 1) == objetivoSoma)
                    {
                        if (numbers.Any(a => a + (x + x + x + numbers[i]) == objetivoSoma))
                        {
                            int z = numbers.First(v => v + (x + x + x + numbers[i]) == objetivoSoma);
                            listRetornoUnico.Add($"{x},{x},{x},{numbers[i]},{z}");
                        }
                        else
                        {
                            listRetornoGenerico.Add($"{x},{x},{x},{numbers[i]}");
                        }
                    }
                    else if ((x + x + x + numbers[i] + 2) == objetivoSoma)
                    {
                        if (numbers.Any(a => a + (x + x + x + numbers[i]) == objetivoSoma))
                        {
                            int z = numbers.First(v => v + (x + x + x + numbers[i]) == objetivoSoma);
                            listRetornoUnico.Add($"{x},{x},{x},{numbers[i]},{z}");
                        }
                        else
                        {
                            listRetornoGenerico.Add($"{x},{x},{x},{numbers[i]}");
                        }
                    }

                    if ((x + menorNum + maiorNum + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{menorNum},{maiorNum},{numbers[i]}");
                    }
                    if ((x + menorNum + x + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{menorNum},{x},{numbers[i]}");
                    }
                    if ((x + maiorNum + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{maiorNum},{numbers[i]}");
                    }
                    if ((x + menorNum + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{menorNum},{numbers[i]}");
                    }
                    if ((x + numbers[i] + maiorNum) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{maiorNum},{numbers[i]}");
                    }
                    if ((x + numbers[i]) == objetivoSoma)
                    {
                        listRetornoUnico.Add($"{x},{numbers[i]}");
                    }

                }
                if ((x + maiorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{maiorNum},{x}");
                }
                if ((x + maiorNum) < objetivoSoma)
                {
                    if (numbers.Any(a => ((x + maiorNum) + a) == objetivoSoma))
                    {
                        int? n = numbers.FirstOrDefault(a => (x + maiorNum) + a == objetivoSoma);
                        int? m = numbers.LastOrDefault(a => (x + maiorNum) + a == objetivoSoma);
                        if (n != null && m != null)
                        {
                            if (n != 0 && m != 0)
                            {
                                if (n > m)
                                {
                                    listRetornoUnico.Add($"{x},{maiorNum},{n}");
                                }
                                else
                                {
                                    listRetornoUnico.Add($"{x},{maiorNum},{m}");
                                }
                            }
                        }

                    }
                }
                if ((maiorNum + maiorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{maiorNum},{maiorNum}");
                }
                if ((maiorNum + maiorNum) < objetivoSoma)
                {
                    int totalAux = (maiorNum + maiorNum);
                    if (numbers.Any(z => (z + totalAux) == objetivoSoma))
                    {
                        int? n = numbers.FirstOrDefault(c => (c + totalAux) == objetivoSoma);
                        int? m = numbers.LastOrDefault(c => (c + totalAux) == objetivoSoma);
                        if (n != null && m != null && m != 0 && n != 0)
                        {
                            if (n > m)
                            {
                                listRetornoUnico.Add($"{maiorNum},{maiorNum},{n}");
                            }
                            else
                            {
                                listRetornoUnico.Add($"{maiorNum},{maiorNum},{m}");
                            }
                        }
                    }
                }
                if ((menorNum + menorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{menorNum},{menorNum}");
                }
                if ((menorNum + menorNum) < objetivoSoma)
                {
                    int totalAux = (menorNum + menorNum);
                    if (numbers.Any(z => (z + totalAux) == objetivoSoma))
                    {
                        int? n = numbers.FirstOrDefault(c => (c + totalAux) == objetivoSoma);
                        int? m = numbers.LastOrDefault(c => (c + totalAux) == objetivoSoma);
                        if (n != null && m != null && m != 0 && n != 0)
                        {
                            if (n > m)
                            {
                                listRetornoUnico.Add($"{menorNum},{menorNum},{n}");
                            }
                            else
                            {
                                listRetornoUnico.Add($"{menorNum},{menorNum},{m}");
                            }
                        }
                    }
                }
                if ((maiorNum + maiorNum + x) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{maiorNum},{maiorNum},{x}");
                }
                if ((x + x + x + x + x) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{x},{x},{x}");
                }
                else if (numbers.Any(a => a + (x + x + x + x + x) == objetivoSoma))
                {
                    int m = numbers.First(a => a + (x + x + x + x + x) == objetivoSoma);
                    listRetornoUnico.Add($"{x},{x},{x},{x},{x},{m}");
                }
                else
                {
                    if ((x + x + x + x + x) < objetivoSoma)
                    {
                        int p = ((x + x + x + x + x) - objetivoSoma);
                        if (p >= -3 && p <= 0)
                        {
                            listRetornoGenerico.Add($"{x},{x},{x},{x},{x}");
                        }
                    }
                }
                if ((x + x + x + x) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{x},{x}");
                }
                if ((x + x + x) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{x}");
                }

                else if (numbers.Any(a => a + (x + x + x) == objetivoSoma))
                {
                    int m = numbers.First(a => a + (x + x + x) == objetivoSoma);
                    listRetornoUnico.Add($"{x},{x},{x},{m}");
                }
                if ((x + x) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x}");
                }
                if ((maiorNum * 2 < objetivoSoma))
                {
                    if ((maiorNum * 3 < objetivoSoma))
                    {
                        if ((maiorNum * 4) > objetivoSoma)
                        {
                            listRetornoGenerico.Add($"{maiorNum},{maiorNum},{maiorNum}");
                        }
                        else
                        {
                            if ((maiorNum * 5) > objetivoSoma)
                            {
                                listRetornoGenerico.Add($"{maiorNum},{maiorNum},{maiorNum},{maiorNum}");
                            }
                            else
                            {
                                int total = maiorNum * 5;
                                if (numbers.Any(z => (z + total) == objetivoSoma))
                                {
                                    int m = numbers.First(z => (z + total) == objetivoSoma);
                                    listRetornoGenerico.Add($"{maiorNum},{maiorNum},{maiorNum},{maiorNum},{maiorNum},{m}");
                                }
                                else
                                {
                                    if ((total - objetivoSoma) >= -3 && (total - objetivoSoma) <= 0)
                                    {
                                        listRetornoGenerico.Add($"{maiorNum},{maiorNum},{maiorNum},{maiorNum},{maiorNum}");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        if ((maiorNum * 3 == objetivoSoma))
                        {
                            listRetornoUnico.Add($"{maiorNum},{maiorNum},{maiorNum}");
                        }
                    }
                }
                else
                {
                    if ((maiorNum * 2 == objetivoSoma))
                    {
                        listRetornoUnico.Add($"{maiorNum},{maiorNum}");
                    }
                }
                if (x == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x}");
                }
                if ((x + maiorNum + menorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{maiorNum},{menorNum}");
                }
                if ((x + maiorNum + maiorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{maiorNum},{maiorNum}");
                }
                if ((x + menorNum + menorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{menorNum},{menorNum}");
                }
                if ((x + maiorNum + menorNum + x) < objetivoSoma)
                {
                    int totalAux = (x + maiorNum + menorNum + x);
                    if (numbers.Any(z => (z + totalAux) == objetivoSoma))
                    {
                        int? n = numbers.FirstOrDefault(c => (c + totalAux) == objetivoSoma);
                        int? m = numbers.FirstOrDefault(c => (c + totalAux) == objetivoSoma);
                        if (n != null && m != null && n != 0 && m != 0)
                        {
                            if (n > m)
                            {
                                listRetornoUnico.Add($"{x},{maiorNum},{menorNum},{x},{n}");
                            }
                            else
                            {
                                listRetornoUnico.Add($"{x},{maiorNum},{menorNum},{x},{m}");
                            }
                        }
                    }
                }
                if ((x + x + x + maiorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{x},{maiorNum}");
                }
                else if ((x + x + x + maiorNum) < objetivoSoma && numbers.Any(k => (k + x + x + x + maiorNum) == objetivoSoma))
                {
                    int totalAux = (x + x + x + maiorNum);
                    int? n = numbers.FirstOrDefault(c => (c + totalAux) == objetivoSoma);
                    int? m = numbers.LastOrDefault(c => (c + totalAux) == objetivoSoma);
                    if (n != null && m != null && n > m)
                    {
                        listRetornoUnico.Add($"{x},{x},{x},{maiorNum},{n}");
                    }
                    else
                    {
                        if (m == 0)
                        {
                            listRetornoGenerico.Add($"{x},{x},{x},{maiorNum}");
                        }
                        else
                        {
                            listRetornoGenerico.Add($"{x},{x},{x},{maiorNum},{m}");
                        }
                    }
                }
                if ((x + x + x + menorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{x},{menorNum}");
                }
                if ((x + x + maiorNum + maiorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{maiorNum},{maiorNum}");
                }
                if ((x + x + menorNum + menorNum) == objetivoSoma)
                {
                    listRetornoUnico.Add($"{x},{x},{menorNum},{menorNum}");
                }
            }
            if (listRetornoUnico.Count > 0)
            {
                return listRetornoUnico.Distinct().OrderBy(x => x.Length).ToList<string>();
            }
            else
            {
                return listRetornoGenerico.Distinct().OrderBy(x => x.Length).ToList<string>();
            }


        }


    }
}