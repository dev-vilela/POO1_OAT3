using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice7
    {
        public void Exercice7()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 07");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Por favor, informe a temperatura em graus Fahrenheit");
            double Temp_Fah = double.Parse(Console.ReadLine());

            double Temp_Cel = (Temp_Fah - 32) * 5 / 9;

            Console.WriteLine($"Temperatura em graus Celsius é de: {Temp_Cel}");



            Console.ReadLine();





            // ------------------------
        }
    }
}
