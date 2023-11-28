using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice2
    {
        public void Exercice2()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 02");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe o valor da cotação do dolar:");
            double Ct_dolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em dolares: ");
            double Vl_dolar = double.Parse(Console.ReadLine());

            double Valor_Real = Ct_dolar * Vl_dolar;

            Console.WriteLine("O valor em Dolar é: {Valor_Real} ");


            Console.ReadLine();





            // ------------------------
        }
    }
}
