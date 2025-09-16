using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace ExerciciosMetodos
{
    class Program
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("==Calculadora==");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("0 - Sair");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Somar();
                        break;
                    case "2":
                        Subtrair();
                        break;
                    case "3":
                        Multiplicar();
                        break;
                    case "4":
                        Dividir();
                        break;
                    case "0":
                        Console.WriteLine("Encerrando...");
                        return;
                    default:
                        Console.WriteLine("Algo deu errado, escolha uma das opçoes");
                        break;

                }

            }
            static void Somar()
            {
                if (LerDoisNumeros(out double a, out double b))
                {
                    Console.WriteLine($"Resultado:{a + b}");
                }

            }
            static void Subtrair()
            {
                if (LerDoisNumeros(out double a, out double b))
                {
                    Console.WriteLine($"Resultado: {a - b}");
                }
            }
            static void Multiplicar()
            {
                if (LerDoisNumeros(out double a, out double b))
                {
                    Console.WriteLine($"Resultado: {a * b}");
                }
            }
            static void Dividir()
            {
                if (LerDoisNumeros(out double a, out double b))
                {
                    if (b == 0) Console.WriteLine("ERRO: Divisivel por 0");
                    else Console.WriteLine($"Resultado: {a / b}");
                }
            }




        }

        static bool LerDoisNumeros(out double x, out double y)
        {
            Console.WriteLine("Digite um numero");
            if (!double.TryParse(Console.ReadLine(), out x))
            {
                y = 0;
                Console.WriteLine("ERRO: Numero divisivel por 0");
                return false;

            }
            Console.WriteLine("Digite o segundo numero");
            if (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Numero invalido)");
                return false;
            }
            return true;

        }



    }
}














