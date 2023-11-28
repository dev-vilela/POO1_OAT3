using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice8
    {
        public void Exercice8()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 08");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o raio do oleo: ");
            double Raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata do oleo: ");
            double Alt = double.Parse(Console.ReadLine());

            double Vol = 3.14159 * Raio * Raio * Alt;

            Console.WriteLine($"Volume da lata informada é de: {Vol}");

            Console.ReadLine();





            // ------------------------
        }
    }
}
