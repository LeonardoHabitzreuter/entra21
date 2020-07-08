using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            var result = Console.ReadLine();
            
            // Transformando o texto que o usuário digitou para um tipo numérico
            var userAge = Int32.Parse(result);

            // Comparando SE a idade do usuário é maior que 15 E menor que 51
            if (userAge > 15 && userAge < 51)
            {
                Console.WriteLine("Sim, você tem idade para o Entra21");
            }
            else if (userAge == 14 || userAge == 15)
            {
                Console.WriteLine("Você não tem idade para o Entra21, mas tem para ser menor aprendiz");
            }
            else
            {
                Console.WriteLine("Não, você não tem idade nem para o Entra21 e nem para ser menor aprendiz");
            }

            Console.WriteLine("Só isso, mais nada!");
        }
    }
}
