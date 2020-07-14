using System;
using System.Collections.Generic;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Qual a sua idade?");
            // var result = Console.ReadLine();
            // int userAge = Int32.Parse(result);

            // if (userAge > 15 && userAge < 51)
            // {
            //     Console.WriteLine("Você tem idade para o Entra21");
            // }
            // else if (userAge == 14 || userAge == 15)
            // {
            //     Console.WriteLine("Você não tem idade para o Entra21, mas tem para ser menor aprendiz");
            // }
            // else
            // {
            //     Console.WriteLine("Você NÃO tem idade nem para o Entra21 e nem para ser menor aprendiz");
            // }

            // Console.WriteLine("Até mais!");

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
