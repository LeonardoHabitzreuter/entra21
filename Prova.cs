using System;
using System.Text;

namespace getting_started
{
    class Prova
	{
        static void Question1()
        {
            Console.WriteLine("Quantas horas você trabalha por dia?");
            var workHours = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Quantos minutos você trabalha por dia?");
            var minutesWorking = Double.Parse(Console.ReadLine());

            var wholeTime = workHours + (minutesWorking / 60);
            
            System.Console.WriteLine("Qual o seu valor/hora?");
            var workPrice = Double.Parse(Console.ReadLine());

            var dayPrice = (wholeTime * workPrice).ToString("0.00");

            System.Console.WriteLine($"Você ganha {dayPrice} em um dia trabalhado");
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
            var input = 0;

            System.Console.WriteLine("Qual o ano em que você nasceu?");
            while(true)
            {
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Ano inválido! Informe novamente");
                }
            }
            
            if (input <= 2002)
            {
                System.Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                System.Console.WriteLine("Você é menor de idade!");
            }
        }

        public static void Main()
        {
            Question1();
        }
    }
}