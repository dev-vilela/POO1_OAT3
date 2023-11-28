using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice24
    {
        public void Exercice24()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 24");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe o primeiro numero.");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero.");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a opção que deseja.");
            Console.WriteLine("1 - Verificar se um dos números  é ou não múltiplo do outro. ");
            Console.WriteLine("2 - Verificar se os dois números lidos são pares.");
            Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7.");
            Console.WriteLine("4 - Sair");

            int esc = int.Parse(Console.ReadLine());

            switch(esc)
            {
                case 1:
                    if (num1 % num2 == 0 || num2 % num1 == 0)
                    {
                        Console.WriteLine("Um dos numeros escolhidos é multiplo do outro.");
                    }
                    else
                    {
                        Console.WriteLine("Numero não multiplo um do outro.");

                    }
                    break;

                case 2:
                    if (num1 % 2 == 0 || num2 % 2 == 0)
                    {
                        Console.WriteLine($"Os numeros escolhidos são pares.{num1} e {num2}");
                    }
                    else
                    {
                        Console.WriteLine("Um dos numeros é par.");

                    }
                    break;

                case 3:
                    double media = (num1 + num2) / 2;
                    if (media > 7)
                    {
                        Console.WriteLine($"A media dos numeros escolhidos {num1} e {num2} = {media}, é maior que 7.");
                    }
                    else
                    {
                        Console.WriteLine($"A media dos numeros escolhidos {num1} e {num2} = {media} é menor que 7.");
                    }
              
                    break;

                case 4:
                    Console.WriteLine("Encerrar operação");
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
                }

                Console.ReadLine();
            }
           

            // ------------------------
        }
    }

