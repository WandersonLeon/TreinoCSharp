using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();

    }

    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor");
        float num1 = float.Parse(s: Console.ReadLine());

        Console.WriteLine("Segundo Valor");
        float num2 = float.Parse(s: Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"\n O resultado da SOMA é : {resultado}");

        Console.ReadKey();
        Menu();

    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Insira o PRIMEIRO valor: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira o SEGUNDO valor: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"\n O resultado da Subtração é : {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor:");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor:");
        double v2 = double.Parse(Console.ReadLine());

        if (v2 == 0)
        {
            Console.WriteLine("Erro!! \nDivisão por ZERO não é permitida");
            Console.ReadKey();
            Divisao();
        }
        else
        {
            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão entre {v1} e {v2} é {resultado}!");
        }
        Console.ReadKey();
        Menu();

    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        double v1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double resultado = v1 * v2;
        Console.WriteLine($"O resultado da multiplicação entre {v1} e {v2} é {resultado}");

        Console.ReadKey();
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer ?");
        Console.WriteLine("1 - SOMA");
        Console.WriteLine("2 - SUBTRAÇÃO");
        Console.WriteLine("3 - DIVISÃO");
        Console.WriteLine("4 - MULTIPLICAÇÃO");
        Console.WriteLine("5 - SAIR");

        Console.WriteLine("____________________");
        string resposta = Console.ReadLine(); // Mantenha a entrada como string

        if (string.IsNullOrWhiteSpace(resposta)) // Verifica se está vazia ou nula
        {
            Console.WriteLine("Entrada Invalida. Por favor, insira um valor.");
            Menu(); // Reinicia o menu
        }
        else
        {
            try
            {
                int escolha = int.Parse(resposta); // Converte para número
                switch (escolha)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Divisao();
                        break;
                    case 4:
                        Multiplicacao();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção INVALIDA !\nTente novamente.");
                        Console.ReadKey();
                        Menu();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato Invalido. Por Favor, insira um número");
                Menu();
            }
        }

    }
}