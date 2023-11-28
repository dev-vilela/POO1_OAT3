using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice41
    {
        public void Exercice41()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 41");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe a idade do nadador.");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine($"Nadador com idade de {idade}: Categoria Infantil A.");
            }else if (idade >=8 && idade <= 11)
            {
                Console.WriteLine($"Nadador com idade de {idade}: Categoria Infantil B.");

            }else if (idade >=12 && idade <=13)
            {
                Console.WriteLine($"Nadador com idade de {idade}: Categoria Juvenil A.");

            }else if (idade >=14 && idade <= 17)
            {
                Console.WriteLine($"Nadador com idade de {idade}: Categoria Juvenil B.");

            }
            else
            {
                Console.WriteLine("Nadador adulto. Maior de 18");
            }

            Console.ReadLine();
              } 


            // ------------------------
        }
    }

