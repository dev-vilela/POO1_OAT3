using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice60
    {
        public void Exercice60()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 60 ");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o valor de X");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y");
            double y = double.Parse(Console.ReadLine());

            int quadrante = VerificarQdt(x, y);
        }

        int VerificarQdt(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2; 
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4; 
            }
            else
            {
                return 0;
            }
        }
        //  Console.ReadLine();
        // ------------------------
    }
}

    

