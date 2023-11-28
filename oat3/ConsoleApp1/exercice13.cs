using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice13
    {
        public void Exercice13()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 13");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo  numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o terceiro numero: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                int res = num1;
                num1 = num2;
                num2 = res;
            }
            if (num2 < num3)
            {
                int res = num2;
                num2 = num3;
                num3 = res;
            }
            if (num1 < num2)
            {
                int res = num1;
                num1 = num2;
                num2 = res;
            }

            Console.WriteLine($"Os numeros na ordem decrescente são: {num1}, {num2}, {num3}");

            Console.ReadLine();

            // ------------------------
        }
    }
}
