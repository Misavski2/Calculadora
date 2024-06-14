using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operaçao: ");
            Console.WriteLine("1 - Adiçao");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Multiplicaçao");
            Console.WriteLine("4 - Divisao \n");
   
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um outro numero");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (opcao)
            {
                case 1:
                    {
                        resultado = Adicao(num1, num2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(num1, num2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(num1, num2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(num1, num2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Numero Invalido. Tente outro!");
                        break;
                    }
            }

            Console.WriteLine($"O Resultado da operação entre {num1} e {num2} é: {resultado}");
            Console.ReadLine();

        }

        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;

        }

        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;

        }

        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;

        }

        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;

        }


    }
}