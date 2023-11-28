using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice3
    {
        public void Exercice3()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 03");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Qual é o nome do Vendedor:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o codigo da peça:");
            string Cod = Console.ReadLine();

            Console.WriteLine("Informe o preço da peça: ");
            double Valor_pc = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a quantidade vendida: ");
            double Qtd_Vend = double.Parse(Console.ReadLine());

            double Soma_Venda = Valor_pc * Qtd_Vend;

            double cmss = 0.05 * Soma_Venda;

            Console.WriteLine($"Vendedor : {nome}");
            Console.WriteLine($"O código da peça é : {Cod}");
            Console.WriteLine($"Total da venda foi de : {Soma_Venda:C2}");
            Console.WriteLine($"A comissão do vendedor com (5%) é de: {cmss:C2}");


            Console.ReadLine();





            // ------------------------
        }
    }
}
