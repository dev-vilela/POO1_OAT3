using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice14
    {
        public void Exercice14()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 14");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe o primeiro numero: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine($"O numero {valor1} é maior que o numero {valor2}.");
            }
            else
            {
                Console.WriteLine($"O numero {valor1} é menor que o numero {valor2}.");
            }


            Console.ReadLine();





            // ------------------------
        }
    }
}
