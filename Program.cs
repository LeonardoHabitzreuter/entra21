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
			System.Console.WriteLine((sum / counter).ToString("0.00"));
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

		static void Exercise6()
		{
			var candidates = new (string name, int votes)[2];

			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a seguir:");
				System.Console.WriteLine("1 - Cadastro dos candidatos");
        		System.Console.WriteLine("2 - Vote em um candidato");
        		System.Console.WriteLine("3 - Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == "1")
				{
					var password = "";

					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

					System.Console.WriteLine("Digite o nome do primeiro candidato");
					candidates[0].name = Console.ReadLine();

					System.Console.WriteLine("Digite o nome do segundo candidato");
					candidates[1].name = Console.ReadLine();
				}

				if (mode == "2")
				{
					System.Console.WriteLine($"Insira 1 para votar no candidato {candidates[0].name}, ou 2 para votar no candidato {candidates[1].name}");
					var result = Int32.Parse(Console.ReadLine());
					candidates[result - 1].votes++;
				}

        		if (mode == "3")
				{
					if (candidates[0].votes == candidates[1].votes)
					{
						System.Console.WriteLine("Segundo turno!");
					}
					else
					{
						var winner = (candidates[0].votes > candidates[1].votes) ? candidates[0] : candidates[1];
						System.Console.WriteLine($"O vencedor é: {winner.name}");
						System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
					}
					break;
				}
			}
		}

		static void Main(string[] args)
		{
            Exercise6();
		}
	}
}
