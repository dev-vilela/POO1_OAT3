using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice11
    {
        public void Exercice11()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 11");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o valor de A: ");
            int valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int valorB = int.Parse(Console.ReadLine());

            int res = valorA;
            valorA = valorB;
            valorB = res;

            Console.WriteLine($"Os valores trocados ficam: A = {valorA} e B = {valorB}.");

            Console.ReadLine();





            // ------------------------
        }
    }
}
