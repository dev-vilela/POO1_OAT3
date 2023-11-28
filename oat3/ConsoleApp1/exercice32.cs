using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice32
    {
        public void Exercice32()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 32");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe um numero entre 1 e 10.");
            int num = int.Parse(Console.ReadLine());

            int impar = 0;
            int Soma = 0;

            while (impar < 20)
            {
                if (num % 2 != 0)
                {
                    Soma += num * num;
                    impar++;
                }
                num++;
            }
            Console.WriteLine($"A soma dos 20 primeiros quadrados é {Soma}.");

            Console.ReadLine();
            }
           

            // ------------------------
        }
    }

