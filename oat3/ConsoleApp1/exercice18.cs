using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice18
    {
        public void Exercice18()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 18");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe um valor de codigo (1,2,3). ");
            string valor = (Console.ReadLine());

            if (int.TryParse(valor, out int cod))
            {
                switch(cod) {
                    case 1:
                        Console.WriteLine("Numero UM");
                        break;

                    case 2:
                        Console.WriteLine("Numero DOIS");
                        break;

                    case 3:
                        Console.WriteLine("Numero TRES");
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }


            Console.ReadLine();





            // ------------------------
        }
    }
}
