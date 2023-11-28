using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice51
    {
        public void Exercice51()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 51");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe a quantidade de alunos. ");
            int QtdAluno = int.Parse(Console.ReadLine());

            double Notas = 0;
            int Alunos7 = 0;

            for(int i = 1; i <= QtdAluno; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}.");
                double nota = double.Parse(Console.ReadLine()); 

                if(nota < 0 || nota > 10)
                {
                    Console.WriteLine("Nota invalida");
                }
                else
                {
                    Notas += nota;

                    if (nota >= 7)
                    {
                        Alunos7++;
                    }
                }
            }

            double media = Notas / QtdAluno;

            Console.WriteLine($"A media do aluno é {media} ");

            if (Alunos7 > 0)
            {
                Console.WriteLine($"Alunos acima de 7: {Alunos7}");
            }
            else
            {
                Console.WriteLine("Nenhum aluno esta com media acima de 7");
            }

            Console.ReadLine();
        }

        //
        // ------------------------
    }
}
    

