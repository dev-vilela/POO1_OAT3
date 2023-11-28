using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace oat3
{
    public class exercice63
    {
        public void Exercice63()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 63 ");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe um numero.");
            int num = int.Parse(Console.ReadLine());

            string res = Verificar(num);
            Console.WriteLine($"O numero {num} informado é {res} ");

        }

       static string Verificar(int num)
        {
            if (num % 2 == 0)
            {
                return "PAR";
            }
            else
            {
                return "IMPAR";
            }
        }
        //  Console.ReadLine();
        // ------------------------
    }
}

    

