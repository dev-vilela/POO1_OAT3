using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice33
    {
        public void Exercice33()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 33");
            Console.WriteLine("------*********--------*******---------");

            int Alunos = 1;
            double notas = 0;
            int QtdAluno = 0;

           


            while(true){
                Console.WriteLine("Informe a nota do aluno");
                int nota = int.Parse(Console.ReadLine());

                if (notas < 0)
                {
                    break;
                }

                notas += nota;
                QtdAluno++;
                Alunos++;

                if (QtdAluno > 0)
                {
                    double media = notas / QtdAluno;
                    Console.WriteLine($"A media das notas dos {QtdAluno} são {media}");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            }

           


            Console.ReadLine();
            }
           

            // ------------------------
        }
    }

