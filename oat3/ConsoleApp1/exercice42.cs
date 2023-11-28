using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice42
    {
        public void Exercice42()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 42");
            Console.WriteLine("------*********--------*******---------");

            //int numero;
            int maior = 0;
            int menor = 0;

            

            do
            {
                Console.WriteLine("Informe um numero");
                int num = int.Parse(Console.ReadLine());


                if (num != 0)
                {
                    if (num > maior)
                    {
                        maior = num;   
                    }
                    if (num < menor);
                    {
                        menor = num;
                    }


                }

            } while(Console.ReadLine().ToUpper() == "Sim");

            if (maior != int.MinValue && menor != int.MaxValue)
            {
                Console.WriteLine($"{maior} esse é o maior numero informado.");
                Console.WriteLine($"{menor} esse é o menor numero informado.");

            }
            else
            {
                Console.WriteLine("ERROR");

            }



            Console.ReadLine();
              } 


            // ------------------------
        }
    }

