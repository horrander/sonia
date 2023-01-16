using Microsoft.VisualBasic;
using System.Collections;
using System.Runtime.InteropServices;



namespace SegregacaoDeNumerosPositivos
{
    internal class Program
    {

        //2.    Faça um algoritmo que receba 15 números e exiba somente os positivos para o usuário
        static void Main(string[] args)
        {
            var numeroPositivos = new FluxoDeNumeros();
            numeroPositivos.Executar();

            Console.ReadKey();
        }
    }
}