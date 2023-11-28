using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice10
    {
        public void Exercice10()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 10");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe o primeiro número inteiro: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo número inteiro: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"Os dois numeros inteiros são iguais. {num1} e {num2}");
            }
            else
            {
                Console.WriteLine("Os numeros são diferentes");
            }
            if (num1 > num2)
            {
                Console.WriteLine($"O {num1} é maior que {num2}.");
            }
            else
            {
                Console.WriteLine($"O {num1} é menor que o {num2}.");
            }
            if (num1 >= num2)
            {
                Console.WriteLine($"Numero {num1} e maior ou igual que {num2}");
            }
            else
            {
                Console.WriteLine($"Numero {num1} é menor que o numero {num2}.");
            }
            if (num1 <= num2)
            {
                Console.WriteLine($"O numero {num1} é menor ou igual que o numero {num2}.");
            }
            else
            {
                Console.WriteLine($"O numero {num1} é maior que o numero {num2}. ");
            }


            Console.WriteLine($"O numero {num1} é igual que o numero {num2} :{num1 == num2}.");
            Console.WriteLine($"O numero {num1} é diferente do numero {num2} :{num1 != num2}");
            Console.WriteLine($"O numero {num1} é maior que o numero {num2} :{num1 > num2}");
            Console.WriteLine($"O numero {num1} é menor que o numero {num2} :{num1 < num2}");
            Console.WriteLine($"O numero {num1} é maior ou igual que o numero {num2} :{num1 >= num2}");
            Console.WriteLine($"O numero {num1} é menor ou igual que o numero {num2} :{num1 <= num2}");



            Console.ReadLine();


            // ------------------------
        }
    }
}
