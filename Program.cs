using System;

namespace Soma_2_Números
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;

            Console.WriteLine("Digite o valor 1: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine($"Seu Resultado é: {valor1 + valor2}");

            Console.WriteLine("Pressione Enter para sair");
            Console.ReadKey();
        }
    }
}
