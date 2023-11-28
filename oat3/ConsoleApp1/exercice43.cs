using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice43
    {
        public void Exercice43()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 43");
            Console.WriteLine("------*********--------*******---------");

            int numXadrez = 64;
            int GraosIn = 1;
            int TotalG = 0;

            for(int i = 1;1 <= numXadrez; i++)
            {
                Console.WriteLine($"O quadrado {i}: {GraosIn}");
                TotalG += GraosIn;
                GraosIn *= 2;

                Console.ReadLine();

            }
            Console.WriteLine($"O total de graos a serem recebido é de {TotalG}.");

           
              } 


            // ------------------------
        }
    }

