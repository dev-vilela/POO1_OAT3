using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice50
    {
        public void Exercice50()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 50");
            Console.WriteLine("------*********--------*******---------");

            Random random = new Random();

            
            int Sorteado = random.Next(101);

          
            int tentativa;

            
            int tentativas = 0;

            Console.WriteLine(" Adivinha o número sorteado entre 0 e 100.");

            do
            {
                Console.Write("Digite sua tentativa: ");
                tentativa = Convert.ToInt32(Console.ReadLine());

             
                tentativas++;

                if (tentativa < Sorteado)
                {
                    Console.WriteLine("O número sorteado é maior. ");
                }
                else if (tentativa > Sorteado)
                {
                    Console.WriteLine("O número sorteado é menor. ");
                }
                else
                {
                    Console.WriteLine($"Meus parabéns! Você acertou o número {Sorteado} em {tentativas} tentativas.");
                }

            } while (tentativa != Sorteado);
        }




    }

        //Console.ReadLine();
            // ------------------------
        }
    

