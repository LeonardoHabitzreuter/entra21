using System;

namespace primeira_aula
{
    class Program
    {
        static void Exercise1()
        {
            var increment = 1;

            System.Console.WriteLine("crescente");
            while (increment < 11)
            {
                System.Console.WriteLine(increment);
                increment++;
            }

            var decrement = 10;

            System.Console.WriteLine("decrescente");
            while (decrement > 0)
            {
                System.Console.WriteLine(decrement);
                decrement--;
            }

            var counter = 2;
            System.Console.WriteLine("apenas os pares");
            while (counter < 11)
            {
                if (counter % 2 == 0)
                {
                    System.Console.WriteLine(counter);
                }
                counter++;
            }
        }

        static void Exercise2()
        {
            var counter = 1;
            var sum = 0;

            while (counter < 101)
            {
                sum += counter;
                counter++;
            }

            System.Console.WriteLine("a soma dos números inteiros entre 1 e 100 é");
            System.Console.WriteLine(sum);
        }

        static void Exercise3()
        {
            var counter = 1;

            while (counter < 200)
            {
                if (counter % 2 == 1)
                {
                    System.Console.WriteLine(counter);
                }
                counter++;
            }
        }

        static void Exercise4()
        {
            var sum = 0.0;
            var counter = 0.0;

            while (true)
            {
                System.Console.WriteLine("Digite uma idade");
                var result = Console.ReadLine();

                if (result == "0")
                {
                    break;
                }
                
                counter++;
                
                sum += Int32.Parse(result);
            }

            System.Console.WriteLine("A média da turma é:");
            System.Console.WriteLine(sum / counter);
            System.Console.WriteLine(String.Format("{0:0.00}", sum / counter));
        }

        static void Exercise5()
        {
            var womenBetween18And35 = 0;

            var counter = 0;
            while (counter < 5)
            {
                System.Console.WriteLine("Digite o nome de uma mulher");
                Console.ReadLine();
                System.Console.WriteLine("Digite sua idade");
                var age = Int32.Parse(Console.ReadLine());

                if (age > 17 && age < 36)
                {
                    womenBetween18And35++;
                }
                counter++;
            }

            System.Console.WriteLine("A porcentagem de mulheres entre 18 e 35");
            System.Console.WriteLine(womenBetween18And35 * 100 / 5);
        }

        static void Main(string[] args)
        {
            var names = new string[3];
            var counter = 0;

            while (counter < 3)
            {
                System.Console.WriteLine("Digite um nome");
                var result = Console.ReadLine();
                
                names[counter] = result;
                counter++;
            }

            System.Console.WriteLine($"Olá, {names[0]}!");
            System.Console.WriteLine($"Olá, {names[1]}!");
            System.Console.WriteLine($"Olá, {names[2]}!");
        }
    }
}
