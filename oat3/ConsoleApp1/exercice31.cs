using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice31
    {
        public void Exercice31()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 31");
            Console.WriteLine("------*********--------*******---------");

            int Par = 0;
            int Impar = 0;

            

            do
            {
                Console.WriteLine("Informe um numero ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 < 0)
                {
                    break;
                }


                if (num1 % 2 == 0)
                {
                    Console.WriteLine($"O numero escolhido {num1} é par.");
                    Par += num1;
                }
                else
                {
                    Console.WriteLine($"O numero escolhido {num1} é impar.");
                    Impar += num1;


                }

            } while (true);

            Console.WriteLine($"A soma dos numeros pares é : {Par}");
            Console.WriteLine($"A soma dos numeros impares é : {Impar}");

            Console.ReadLine();
            }
           
           
            


            // ------------------------
        }
    }

