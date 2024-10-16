using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;
            
            if(time == 0)
                System.Environment.Exit(0);

            PreInicio(time * multiplier);
        }

        static void PreInicio(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo...");
            Thread.Sleep(2500);

            Inicio(time);
        }

        static void Inicio(int tempo)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.Write(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado!! ");
            Thread.Sleep(3000);
            Menu();
        }
    }
}