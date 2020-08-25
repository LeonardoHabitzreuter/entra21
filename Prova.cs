using System;
using System.Collections.Generic;
using System.Text;

namespace getting_started
{
    class Prova
	{
        static void Question1()
        {
            Console.WriteLine("Quantas horas (com minutos) você trabalha por dia?");
            var timeWorking = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual o seu valor/hora?");
            var workPrice = Double.Parse(Console.ReadLine());
            var dayEarn = (timeWorking * workPrice).ToString("0.00");

            System.Console.WriteLine($"Você ganha {dayEarn} em um dia trabalhado");
        }

        static void Question2()
        {
            var word = "";
            while (true)
            {
                Console.WriteLine("Digite uma letra");
                var letter = Console.ReadLine();
                if (letter == "Finalizar")
                {
                    break;
                }
                word += letter;
            }

            System.Console.WriteLine($"A palavra é: {word}");
        }

        static void Question3()
        {
            var singleMen = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu nome");
                var name = Console.ReadLine();
                Console.WriteLine("Você é solteiro?");
                var isSingle = Console.ReadLine();
                if (isSingle == "sim")
                {
                    singleMen.Append($"{name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);
            Console.WriteLine($"Todos os solteiros: {singleMen}");
        }

        static void Question4()
        {
            var singleMen = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu nome");
                var name = Console.ReadLine();
                Console.WriteLine("Você é solteiro?");
                var isSingle = Console.ReadLine();
                if (isSingle == "sim")
                {
                    singleMen.Append($"{name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);
            Console.WriteLine($"Todos os solteiros: {singleMen}");
        }

        public static void Main()
        {
            Question1();
        }
    }
}