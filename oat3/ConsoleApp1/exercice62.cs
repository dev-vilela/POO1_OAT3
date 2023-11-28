using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice62
    {
        public void Exercice62()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 62 ");
            Console.WriteLine("------*********--------*******---------");


            Console.WriteLine("Informe o valor da base do triangulo.");
            double baseTri = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da altura do triangulo.");
            double alturaTri = double.Parse(Console.ReadLine());

            double hipotenusa = CALC(baseTri, alturaTri);
            Console.WriteLine($"A hipotenusa do triangulo é  {hipotenusa}. ");
   
        }

      static  double CALC(double baseTri, double alturaTri)
        {
            double hipotenusa = Math.Sqrt(Math.Pow(baseTri, 2) + Math.Pow(alturaTri, 2));
            return hipotenusa;

        }

      
        }
        //  Console.ReadLine();
        // ------------------------
    }


    

