using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice39
    {
        public void Exercice39()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 39");
            Console.WriteLine("------*********--------*******---------");

            do
            {
                Console.WriteLine("Informe um numero.");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine($"O numero informado {num} é par");
                }
                else
                {
                    Console.WriteLine($"O numero informado {num} é impar.");

                }

                if (num > 0)
                {
                    Console.WriteLine($"O numero {num} é positivo.");
                }else if (num <0)
                {
                    Console.WriteLine($"O numero informado {num} é negativo.");

                }
                else
                {
                    Console.WriteLine("Numero ZERO.");
                }

                Console.Write("Deseja encerrar o programa? (Sim/Não): ");

            } while (Console.ReadLine().ToUpper() == "Sim");

            Console.ReadLine();
              } 


            // ------------------------
        }
    }

