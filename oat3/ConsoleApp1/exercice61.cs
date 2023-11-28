using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice61
    {
        public void Exercice61()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 61 ");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o valor do salario");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o indice do reajuste");
            double reajuste = double.Parse(Console.ReadLine());

            double salAtual = Atual(salario, reajuste);
            Console.WriteLine($"O salario atualizado é R$ {salAtual}. ");
   
        }

      static  double Atual(double salario, double reajuste)
        {
            double CReaj = 1 + (reajuste / 100);
            double salAtual = salario * CReaj;

            return salAtual;

        }

      
        }
        //  Console.ReadLine();
        // ------------------------
    }


    

