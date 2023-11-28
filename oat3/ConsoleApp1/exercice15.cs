using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice15
    {
        public void Exercice15()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 15");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe a primeiro nota do aluno(a) : ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno(a): ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno(a): ");
            double valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota do aluno(a): ");
            double valor4 = double.Parse(Console.ReadLine());

            double media = (valor1 + valor2 + valor3 + valor4) / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Meus Parabens, você foi Aprovado com a média de {media}. ");
            }
            else
            {
                Console.WriteLine($"Você ficou de recuperação com media de {media}");
            }

            Console.WriteLine("Informe a nota de recuperação do aluno(a) : ");
            double notarec = double.Parse(Console.ReadLine());

            double mediarec = (media + notarec) / 2;

            if (mediarec >= 7)
            {
                Console.WriteLine($"O aluno foi aprovado, media da recuperação é de {mediarec}");
            }
            else
            {
                Console.WriteLine($"O aluno foi reprovado, com media de {mediarec}");
            }


            Console.ReadLine();





            // ------------------------
        }
    }
}
