using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice49
    {
        public void Exercice49()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 49 não rodou");
            Console.WriteLine("------*********--------*******---------");


            int QtdMax = 50;



            Console.WriteLine("Informe o tamanho do vetor");
            int num = int.Parse(Console.ReadLine());

           int[] v1 = new int[num];
           int[] v2 = new int[num];

            Vetor1("v1", v1);
            Vetor1("v2", v2);

           // int QtdIdentico = VlrIdentico(v1, v2);

        }
        static void Vetor1(string NVetor, int[] vetor)
        {
            Console.WriteLine($"Informe os valores para o vetor {NVetor}:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Informe o valor na posição {i + 1}: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        void VlrIdentico(int[] vetor1, int[] vetor2)
        {
            int QtdIdentico = 0;
            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == vetor2[i])
                {
                    QtdIdentico++;
                }
               
            }
            
        }


            // ------------------------
        }
    }

