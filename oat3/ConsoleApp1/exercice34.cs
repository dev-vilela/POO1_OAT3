using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice34
    {
        public void Exercice34()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 34");
            Console.WriteLine("------*********--------*******---------");

            double num = 0;
            double maior = 0;
            double menor = 0;

            while (true)
            {
                Console.WriteLine("Informe um numero.");
                int num1 = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    break;
                }

                if (num < menor)
                {
                    menor = num;
                }
                if (num > maior)
                {
                    maior = num; 
                }

                if (menor == double.MaxValue && maior == double.MinValue)
                {
                    Console.WriteLine("Nenhum número positivo inserido. Programa encerrado.");
                }
                else
                {
                    Console.WriteLine($"O menor número é: {menor}");
                    Console.WriteLine($"O maior número é: {maior}");
                }

            }


            Console.ReadLine();
            }
           

            // ------------------------
        }
    }

