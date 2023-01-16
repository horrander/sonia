using System;

namespace ProgramaMatrizSomaNumerosPositivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################################");
            Console.WriteLine("###Programa para soma de números positivos em Bingo###");
            Console.WriteLine("######################################################");

            int quantidadeLinhas, quantidadeColunas;

            Console.WriteLine("Quantas linhas a sua cartela tem? ");
            string? linhasInformadas = Console.ReadLine();
            quantidadeLinhas = Convert.ToInt32(linhasInformadas);

            Console.WriteLine("Quantas linhas a sua cartela tem? ");
            string? colunasInformadas = Console.ReadLine();
            quantidadeColunas = Convert.ToInt32(colunasInformadas);

            var matrizNumeros = new int[quantidadeLinhas, quantidadeColunas];

            for (int contadorLinhas = 0; contadorLinhas < quantidadeLinhas; contadorLinhas++);
            {
                for (int contadorColunas = 0; contadorColunas < quantidadeColunas; contadorColunas++) ;
                {
                        Console.WriteLine($"Informe o número da {contadorLinhas + 1} linha, da {contadorColunas + 1}: ");
                        Convert.ToInt32(Console.ReadLine());    
                }

            }
         }
    }
}