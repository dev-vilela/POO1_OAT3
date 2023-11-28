using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice45
    {
        public void Exercice45()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 45");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o tamanho da sequencia desejada.");
            int sq = int.Parse(Console.ReadLine());

            int[] num = new int[sq];
            for(int i = 0; i < sq; i++)
            {
                Console.WriteLine($"Informe o {i + 1} numero ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Sequência na ordem inversa:");

            for (int i = sq - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }

            Console.ReadLine();

        } 


            // ------------------------
        }
    }

