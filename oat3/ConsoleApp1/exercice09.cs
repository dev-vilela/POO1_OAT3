using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice9
    {
        public void Exercice9()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 09");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe a sua idade: ");
            double idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua idade em meses: ");
            double mes = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a sua idade em dias: ");
            double dia = double.Parse(Console.ReadLine());

            double res = (idade * 365) + (mes * 30) + dia;

            Console.WriteLine($"A sua  idade em dias é : {res}");


            Console.ReadLine();





            // ------------------------
        }
    }
}
