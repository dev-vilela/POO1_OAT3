using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice48
    {
        public void Exercice48()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 48");
            Console.WriteLine("------*********--------*******---------");


            int QtdCandidata = 20;

            int[] nome = new int[QtdCandidata];
            int[] idade = new int[QtdCandidata];

            DadosCandidata();

            Console.WriteLine("Apenas  modelo que tenha idade entre 18 e 20 anos");

            for(int i = 0; i < nome.Length; i++)
            {
                if (idade[i] >= 18 && idade[i] <= 20)
                {
                    Console.WriteLine(nome[i]);
                }
            }
            

            void DadosCandidata()
            {
              for(int i = 0; i  <= nome.Length; i++)
                {
                    Console.WriteLine($"Informe o nome da {i + 1} candidata.");
                    nome[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Informe a idade da {i + 1} candidata.");
                    idade[i] = int.Parse(Console.ReadLine());

                } while (idade[1] <= 0)
                {
                    Console.WriteLine("ERROR");
                }

            }
           
            Console.ReadLine();

        } 


            // ------------------------
        }
    }

