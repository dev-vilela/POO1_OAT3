using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice1
    {
        public void Exercice1()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 01");
            Console.WriteLine("------*********--------*******---------");

            //pra que serve
            //tantos códigos? 
            //se a vida
            //não é programada
            //e as melhores coisas
            //não tem lógica.



            Console.WriteLine("Informe o valor maximo do estoque: ");
            int EstMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor minimo do estoque: ");
            double EstMin = double.Parse(Console.ReadLine());


            double Estmedia = (EstMax + EstMin) / 2;

            Console.WriteLine($"A média  do estoque  é : {Estmedia:F2}");

            Console.ReadLine();





            // ------------------------
        }
    }
}
