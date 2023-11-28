using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice17
    {
        public void Exercice17()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 17");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0 && num1 <= 9)
            {
                Console.WriteLine("O numero está valido");
            }
            else
            {
                Console.WriteLine("O numero não é valido");
            }

            Console.ReadLine();





            // ------------------------
        }
    }
}
