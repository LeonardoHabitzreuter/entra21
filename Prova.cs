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

        static void Question5()
        {
            var numbers = new double?[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                try
                {
                    numbers[i] = Double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {}
            }

            System.Console.WriteLine("números válidos:");
            foreach (var number in numbers)
            {
                if(number != null)
                {
                    System.Console.WriteLine(number);
                }    
            }
        }

        static void Question6()
        {
            var answers = 0;
            var sum = 0.0;
            while(true)
            {
                System.Console.WriteLine("Digite seu salário");
                var input = Console.ReadLine();

                if (input == "calcular")
                {
                    break;
                }

                var salary = Double.Parse(input);
                if (salary < 0)
                {
                    continue;
                }

                answers++;
                sum += Double.Parse(input);
            }

            System.Console.WriteLine($"A média salarial é: R${(sum / answers).ToString("0.00")}");
        }

        static void Question7()
        {
            (int id, string UF) scUF = (42, "SC");
            var UFs = new (int id, string UF)[27]
            {
                scUF,
                (11, "RO"),
                (12, "AC"),
                (13, "AM"),
                (14, "RR"),
                (15, "PA"),
                (16, "AP"),
                (17, "TO"),
                (21, "MA"),
                (22, "PI"),
                (23, "CE"),
                (24, "RN"),
                (25, "PB"),
                (26, "PE"),
                (27, "AL"),
                (28, "SE"),
                (29, "BA"),
                (31, "MG"),
                (32, "ES"),
                (33, "RJ"),
                (35, "SP"),
                (41, "PR"),
                (43, "RS"),
                (50, "MS"),
                (51, "MT"),
                (52, "GO"),
                (53, "DF")
            };
            System.Console.WriteLine("Lista de UFs");

            foreach (var item in UFs)
            {
                System.Console.WriteLine($"{item.id} - {item.UF}");
            }

            var bornInSC = 0;
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Digite o ID da UF que representa o estado onde você nasceu");
                var input = Int32.Parse(Console.ReadLine());
                if (input == scUF.id)
                {
                    bornInSC++;
                }
            }

            System.Console.WriteLine("Porcentagem de usuários nascidos em SC:");
            System.Console.WriteLine((bornInSC * 100) / 5);
        }

        static void Question8()
        {
            var studentsPerClass = 5;
            var morningClass = new string[studentsPerClass];
            var afternoonClass = new string[studentsPerClass];
            
            for (int i = 0; i < studentsPerClass; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine("Digite um nome");
                    var input = Console.ReadLine();
                    
                    var currentClass = j == 0 ? morningClass : afternoonClass;
                    currentClass[i] = input;
                }
            }

            var onlyHalfPeriodStudents = true;

            System.Console.WriteLine("Pesquisando por alunos de período integral...");
            foreach (var morningStudent in morningClass)
            {
                foreach (var afternoonStudent in afternoonClass)
                {
                    if (morningStudent == afternoonStudent)
                    {
                        System.Console.WriteLine(morningStudent);
                        onlyHalfPeriodStudents = false;
                    }
                }
            }

            if (onlyHalfPeriodStudents)
            {
                System.Console.WriteLine("todos os alunos estudam em meio período");
            }
        }

        public static void Main()
        {
            Question1();
        }
    }
}