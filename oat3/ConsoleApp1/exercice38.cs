using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice38
    {
        public void Exercice38()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 38");
            Console.WriteLine("------*********--------*******---------");

            do
            {
                Console.WriteLine("Informe o codigo do operario.");
                int cod = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe as horas trabalhadas.");
                int horas = int.Parse(Console.ReadLine());

                double Vhora = 10.00;
                double VhoraEx = 20.00;
                int horaP = 50;

                double salario = horas <= horaP ? horas * Vhora: horaP * Vhora;
                double salarioHEx = horas > horaP ? (horas - horaP) * VhoraEx : 0;

                Console.WriteLine($"O salario do total do operario {cod} é de R$ {salario + salarioHEx }.");
                Console.WriteLine($"Valor da hora extra do operario {cod} é R$ {salarioHEx}.");

                Console.Write("Deseja encerrar o programa? (Sim/Não): ");
            } while (Console.ReadLine().ToUpper() == "Sim");

            Console.ReadLine();
              } 


            // ------------------------
        }
    }

