using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice53
    {
        public void Exercice53()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 53");
            Console.WriteLine("------*********--------*******---------");

           Console.WriteLine("Informe o numero de voltas.");
            int Volta = int.Parse(Console.ReadLine());

            double[] tempo = new double[Volta];

            PreTemp(tempo);

            MelhorTemp(tempo);

            TempoMed(tempo);
           
        }
        void PreTemp(double[] tempo)
        {
            Console.WriteLine("Informe o tempo gasto nas voltas.");

            for(int i = 0; i < tempo.Length; i++)
            {
                Console.WriteLine($"O tempo gasto da volta {i + 1}.");
                tempo[i] = Convert.ToDouble(Console.ReadLine());

                while (tempo[i] <= 0)
                {
                    Console.WriteLine("ERROR ");
                    tempo[i] = Convert.ToDouble(Console.ReadLine());

                }
            }
        }

        void MelhorTemp(double[] tempo)
        {
            double melhorTEMP = tempo[0];
            int VoltaMelhor = 1;

            for(int i = 1;i < tempo.Length;i++)
            {
                if (tempo[i] < melhorTEMP)
                {
                    melhorTEMP = tempo[i];
                    VoltaMelhor = i + 1;
                }
            }

            Console.WriteLine($"O melhor tempo gasto na competição foi, {melhorTEMP} na volta {VoltaMelhor}.");
        }

        void TempoMed(double[] tempo)
        {
            double soma = 0;

            for (int i = 0; i < tempo.Length; i++)
            {
                soma += tempo[i];
            }

            double medio = soma / tempo.Length;

            Console.WriteLine($"O tmepo medio gasto das voltas foram {medio}");
        }
        //  Console.ReadLine();
        // ------------------------
    }
}
    

