using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice30
    {
        public void Exercice30()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 30");
            Console.WriteLine("------*********--------*******---------");
            {
                var num = 4;

                ImprimirTab(num);
            }

             void ImprimirTab(int num)
            {
                Console.WriteLine($"A tabuada do valor informado {num} é: ");

                for(int i = 1; 1 <=10; i++)
                {
                    int res = num * 1;
                    Console.WriteLine($"A o resultado do {num} x {i} é igual a {res} ");
                }
                Console.ReadLine();
            }
           
           
            


            // ------------------------
        }
    }
}
