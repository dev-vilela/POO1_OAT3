using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice23
    {
        public void Exercice23()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 23");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Escolha uma operação desejada.");
            Console.WriteLine("1 - ADIÇÃO");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");

            int esc = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o primeiro numero:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero:");
            double num2 = double.Parse(Console.ReadLine());

            switch (esc)
            {
                case 1:
                    Console.WriteLine($"Opção escolhida ADIÇÃO: {num1 + num2} ");
                    break;

                case 2:
                    Console.WriteLine($"Opção escolhida SUBTRAÇÃO: {num1 - num2} ");
                    break;

                case 3:
                    Console.WriteLine($"Opção escolhida MULTIPLICAÇÃO: {num1 * num2} ");
                    break;

                case 4:
                    Console.WriteLine($"Opção escolhida DIVISÃO: {num1 / num2} ");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.ReadLine();
            }
           
           
            


            // ------------------------
        }
    }

