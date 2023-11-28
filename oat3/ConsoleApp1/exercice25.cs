using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice25
    {
        public void Exercice25()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 25");
            Console.WriteLine("------*********--------*******---------");

            Console.WriteLine("Informe a sua altura.");
            double alt = double.Parse(Console.ReadLine());

            Console.WriteLine("informe seu sexo M (Masculino) e F (Feminino)");
            char sex = Convert.ToChar(Console.ReadLine());

            double peso;

            if (sex == 'M' || sex == 'm')
            {
                peso = (72.7 * alt) - 58;
                Console.WriteLine($"O peso ideal para sua altura de {alt} é de {peso} kg.");

            }
            else if (sex == 'F' || sex == 'f')
            {
                peso = (62.1 * alt) - 44.7;
                Console.WriteLine($"O peso ideal para sua altura de {alt} é de {peso} kg.");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();





            // ------------------------
        }
    }
}
