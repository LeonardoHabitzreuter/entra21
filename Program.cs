using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // var text = "";
            // text = "0";

            var currentDate = DateTime.Now;
            var currentDate2 = DateTime.Now;

            bool datesEquals = currentDate == currentDate2;
            
            // Console.WriteLine(currentDate);
            System.Console.WriteLine();

            // int userAge = Int32.Parse(result);
            
            // bool isLegalAge = userAge >= 18;

            
            // bool isDifferent = result != "olá";

            // bool abc = isEquals == isDifferent;

            // Console.WriteLine("Verificando se o texto é diferente de olá");
            // string result = Console.ReadLine();

            // bool boolean = false;

            // bool abc = !boolean;

            // Console.WriteLine("Verificando se você se chama jonas e tem 16 anos");
            // Console.WriteLine("Qual o seu nome?");
            // string userName = Console.ReadLine();
            // bool userIsJonas = userName == "jonas";

            // Console.WriteLine("Qual a sua idade?");
            // string userAge = Console.ReadLine();
            // var userIs16 = userAge == "16";

            // // Console.WriteLine("Qual sua profissão?");
            // // string userProfession = Console.ReadLine();
            // // bool userIsProgrammer = userProfession == "programador";

            // bool userIsJonasAndIs16AndIsProgrammer = userIsJonas || userIs16;
            // Console.WriteLine(userIsJonasAndIs16AndIsProgrammer);

            // System.Console.WriteLine("Logando o RESTO da divisao 3 / 2");

            // int result = 6 % 2;
            // System.Console.WriteLine(result);

            // System.Console.WriteLine("Digite seu nome");
            // var userName = Console.ReadLine();

            // bool isJose = userName == "José";
            // if (isJose)
            // {
            //     Console.WriteLine("Olá, José");
            // }
            // else
            // {
            //   Console.WriteLine($"Olá, {userName}");
            // }

            // Console.WriteLine("Como vai você?");



            Console.WriteLine("Qual a sua idade?");
            var result = Console.ReadLine();
            int userAge = Int32.Parse(result);

            if (userAge > 15 && userAge < 51)
            {
                Console.WriteLine("Você tem idade para o Entra21");
            }
            else if (userAge == 14 || userAge == 15)
            {
                Console.WriteLine("Você não tem idade para o Entra21, mas tem para ser menor aprendiz");
            }
            else
            {
                Console.WriteLine("Você NÃO tem idade nem para o Entra21 e nem para ser menor aprendiz");
            }

            Console.WriteLine("Até mais!");
        }
    }
}
