using System;
using FormulaLibrary;

namespace CoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONEXÃO PROJETO .NET CORE COM MÓDULO F#");
            Console.WriteLine();

            Console.WriteLine("Soma de quadrados, digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultado: " + Squares.sumOfSquares(numero));

            Console.WriteLine();
            Console.WriteLine("Precificação, digite um valor e uma porcentagem de modificador");
            Console.WriteLine("Valor:");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Porcentagem do modificador:");
            int modificador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Estimativa de preço: " + Pricing.estimate(valor, modificador));

            Console.WriteLine();
            Console.WriteLine("Pressione enter para fechar...");
            Console.ReadLine();
        }
    }
}
