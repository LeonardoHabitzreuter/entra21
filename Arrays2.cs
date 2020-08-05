using System;

namespace arrays
{
	class Array2
	{

		static void Exercise1()
		{
            const int arraysLenght = 15;
            
            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;
                c[i] = a[i] - result;
            }
		}

		static void Exercise2()
		{
            var numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem direta de cadastro:");

            foreach (var item in numbers)
            {
               System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Ordem inversa de cadastro:");

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine(numbers[i]);
            }
		}

		static void Exercise3()
		{
            var numbers = new double[3];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Pesquise um número:");
            var search = Double.Parse(Console.ReadLine());

            var founded = false;

            foreach (var item in numbers)
            {
                if (item == search)
                {
                    founded = true;
                    break;
                }
            }

            if (founded)
            {
               System.Console.WriteLine("O número existe no array"); 
            }
            else
            {
               System.Console.WriteLine("Número inexistente");
            }
		}

		static void Main(string[] args)
		{
            Exercise2();
		}
	}
}
