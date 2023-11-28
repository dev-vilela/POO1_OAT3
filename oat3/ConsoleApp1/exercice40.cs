using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice40
    {
        public void Exercice40()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 40");
            Console.WriteLine("------*********--------*******---------");

            do
            {
                Console.WriteLine("Informe um numero de poluição que foi medido.");
                double indiceP = double.Parse(Console.ReadLine());

                if (indiceP >= 0.05 && indiceP <= 0.25)
                {
                    Console.WriteLine($" {indiceP} indice de poluição aceitavel");
                }
                else if(indiceP > 0.25 && indiceP <= 0.3)
                {
                    Console.WriteLine($"Indústrias do 1º grupo devem suspender suas atividades. Indice de {indiceP}");

                }
                else if( indiceP > 0.3 && indiceP <= 0.4)
                {
                    Console.WriteLine("Industrias do 1o e 2o grupo são intimadas a suspenderem suas atividades");
                }else if (indiceP > 0.4 && indiceP <= 0.5)
                {
                    Console.WriteLine($"Todos os grupos devem ser notificado e paralisado, indice de {indiceP}");
                }
                else
                {
                    Console.WriteLine($"{indiceP} indice alto devem ser bloqueados todas as produção.");
                }



                Console.Write("Deseja encerrar o programa? (Sim/Não): ");

            } while (Console.ReadLine().ToUpper() == "Sim");

            Console.ReadLine();
              } 


            // ------------------------
        }
    }

