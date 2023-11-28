using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice52
    {
        public void Exercice52()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 52");
            Console.WriteLine("------*********--------*******---------");

            int PosicaoMax = 100;

            int[] vetor = new int[PosicaoMax];

            int Cont = 0;
            int num;

            do
            {
                Console.WriteLine($"Informe a posição {Cont + 1}.");
                num = int.Parse( Console.ReadLine() );

                if (num != -1)
                {
                    vetor[Cont] = num;
                    Cont++;
                }
            }while(num != -1 && Cont < PosicaoMax);

            int Cont1 = 0;
            int Cont3 = 0;
            int Cont4 = 0;

            for(int i = 0; i < Cont; i++)
            {
                if (vetor[i] == 1)
                {
                    Cont1++;
                }
                else if (vetor[i] == 3)
                {
                    Cont3++;
                }else if (vetor[i] == 4)
                {
                    Cont4++;
                }
            }

            Console.WriteLine($"\nO número 1 esta aparece {Cont1} vezes.");
            Console.WriteLine($"O número 3 esta aparece {Cont3} vezes.");
            Console.WriteLine($"O número 4 esta aparece {Cont4} vezes.");



             Console.ReadLine();
        }

        //
        // ------------------------
    }
}
    

