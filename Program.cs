using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            var myText = "meu texto";
            var myNumber = 8;
            var myPrice = 4.099;
            var myBoolean = myPrice == myNumber;

            Console.WriteLine("Você é maior de idade?");
            var result = Console.ReadLine();

            myBoolean = result == "sim";

            Console.WriteLine(myText);
            Console.WriteLine(myBoolean);
            Console.WriteLine(myBoolean);
        }
    }
}
