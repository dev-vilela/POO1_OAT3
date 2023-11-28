using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice16
    {
        public void Exercice16()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 16");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"O numero {num1} é maior que o numero {num2}: {num1 > num2}");
            Console.WriteLine($"O numero {num1} é menor que o numero {num2}: {num1 < num2}");
            Console.WriteLine($"O numero {num1} é igual que o numero {num2}: {num1 == num2}");


            Console.ReadLine();

            // ------------------------
        }
    }
}
