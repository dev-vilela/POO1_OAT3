using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice6
    {
        public void Exercice6()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 06");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Por favor, informe a temperatura em graus celsius");
            double Temp_cel = double.Parse(Console.ReadLine());

            double Temp_Fah = (9 * Temp_cel + 160) / 5;

            Console.WriteLine($"Temperatura em Fahrenheit é de: {Temp_Fah}");


            Console.ReadLine();





            // ------------------------
        }
    }
}
