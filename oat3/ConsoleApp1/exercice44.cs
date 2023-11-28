using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat3
{
    public class exercice44
    {
        public void Exercice44()
        {
            Console.WriteLine("------*********--------*******---------");
            Console.WriteLine("Exercicio 44");
            Console.WriteLine("------*********--------*******---------");


            double opcao;
            do
            {
                Menu();
                opcao = VeOp();

                switch (opcao)
                {
                    case 1:
                        ConverterCelsiuspFah();
                        break;

                    case 2:
                        ConverterFahpCelsius();
                        break;

                    case 3:
                        PesoIdeal();
                        break;

  
                    case 4:
                        Console.WriteLine("Encerrar operação");
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }
                Console.Write("Deseja encerrar o programa? (Sim/Não): ");
            } while (Console.ReadLine().ToUpper() == "Sim") ;

            void Menu()
            {
                Console.WriteLine("Escolha uma opção abaixo:");
                Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
                Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
                Console.WriteLine("3 - Peso ideal do homem");
                Console.WriteLine("4 - Peso ideal da mulher");
                Console.WriteLine("5 - Encerrar o programa");
            }

             double VeOp()
            {
                Console.WriteLine("Informe a opção escolhida.");
                return double.Parse(Console.ReadLine());
            }

            void ConverterCelsiuspFah()
            {
                Console.WriteLine("Por favor, informe a temperatura em graus celsius");
                double Temp_cel = double.Parse(Console.ReadLine());

                double Temp_Fah = (9 * Temp_cel + 160) / 5;

                Console.WriteLine($"Temperatura em Fahrenheit é de: {Temp_Fah}");


                Console.ReadLine();
            }

            void ConverterFahpCelsius(){
                Console.WriteLine("Por favor, informe a temperatura em graus Fahrenheit");
                double Temp_Fah = double.Parse(Console.ReadLine());

                double Temp_Cel = (Temp_Fah - 32) * 5 / 9;

                Console.WriteLine($"Temperatura em graus Celsius é de: {Temp_Cel}");

                Console.ReadLine();
            }

            void PesoIdeal(){
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
            }


            Console.ReadLine();

        } 
  // ------------------------
        }
    }

