using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice5
    {
        public void Exercice5()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 05");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Digite o tempo que foi gasto na viagem:");
            double Temp_vg = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a  velocidade media durante a viagem:");
            double Vel_vg = double.Parse(Console.ReadLine());

            double Dist = Temp_vg * Vel_vg;

            double Qtd_litros = Dist / 12;

            Console.WriteLine($"A velocidade Média durante a viagem foi de: {Vel_vg} Km/h");
            Console.WriteLine($"Tempo gasto no percuso foi de: {Temp_vg} horas");
            Console.WriteLine($"A distância percorrida na viagem é de: {Dist} Km");
            Console.WriteLine($"Foi utilizado: {Qtd_litros:F2} litros de gasolina ");


            Console.ReadLine();





            // ------------------------
        }
    }
}
