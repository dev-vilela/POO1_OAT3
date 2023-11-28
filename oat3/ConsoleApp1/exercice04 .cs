using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice4
    {
        public void Exercice4()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 04");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine($"---Olá, logo abaixo segue o questionario para operação de Adição e Multiplicação---");

            Console.WriteLine("Qual o valor de A: ");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de C:");
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor de D:");
            double D = double.Parse(Console.ReadLine());

            Console.WriteLine($"---Resultado da Operação de Adição---");
            Console.WriteLine($"A + B = {A + B}");
            Console.WriteLine($"A + C = {A + C}");
            Console.WriteLine($"A + D = {A + D}");
            Console.WriteLine($"B + C = {B + C}");
            Console.WriteLine($"B + D = {B + D}");
            Console.WriteLine($"C + D = {C + D}");

            Console.WriteLine($"---Resultado da Operação de Multiplicação---");
            Console.WriteLine($"A * B = {A * B}");
            Console.WriteLine($"A * C = {A * C}");
            Console.WriteLine($"A * D = {A * D}");
            Console.WriteLine($"B * C = {B * C}");
            Console.WriteLine($"B * D = {B * D}");
            Console.WriteLine($"C * D = {C * D}");


            Console.ReadLine();





            // ------------------------
        }
    }
}
