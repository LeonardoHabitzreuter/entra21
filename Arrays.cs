﻿using System;
using System.Text;

namespace arrays
{
	class Array
	{
		static void Exercise1()
		{
            const int arraysLenght = 3;
            
            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];
            var output = new StringBuilder();

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");

                while (true)
                {
                    try
                    {
                        a[i] = Double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido, digite outro valor");
                    }
                }
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;
                c[i] = a[i] - result;
                output.Append($"{c[i]} ");
            }

            System.Console.WriteLine("Resultados:");
            System.Console.WriteLine(output);
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

		static void Exercise4()
		{
            const int arraysLenght = 3;
            
            var a = new double?[arraysLenght];
            var b = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            var arraysAreEquals = true;

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;

                var hasEquals = false;

                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result)
                    {
                        hasEquals = true;
                        a[j] = null;
                        break;
                    }
                }

                if (!hasEquals)
                {
                    arraysAreEquals = false;
                }
            }

            var message = arraysAreEquals ? "Os arrays são iguais" : "Os arrays são diferentes";
            System.Console.WriteLine(message);
		}

        static void Exercise5()
        {
            var numbers = new double[15];
            var sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número");
                var input = Double.Parse(Console.ReadLine());
                numbers[i] = input;
                sum += input;
            }

            var average = sum / numbers.Length;
            var greater = 0;
            var equals = 0;
            var lesser = 0;

            foreach (var item in numbers)
            {
                if (item > average)
                {
                    greater++;
                }
                else if (item == average)
                {
                    equals++;
                }
                else
                {
                    lesser++;
                }
            }

            System.Console.WriteLine($"{equals} elementos estão na média");
            System.Console.WriteLine($"{greater} elementos estão acima da média");
            System.Console.WriteLine($"{lesser} elementos estão abaixo da média");
        }

		static void Main(string[] args)
		{
            Exercise5();
		}
	}
}
