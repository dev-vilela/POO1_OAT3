using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice12
    {
        public void Exercice12()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 12");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Por favor, informe um valor inteiro. ");

            string valor = (Console.ReadLine());


            if (double.TryParse(valor, out double num))
            {
                double mod = (num >= 0) ? num : num * (-1);  
            }
            else
            {
                Console.WriteLine("ERROR");
            }


            Console.ReadLine();





            // ------------------------
        }
    }
}
