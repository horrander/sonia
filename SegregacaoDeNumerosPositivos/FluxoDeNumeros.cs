using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacaoDeNumerosPositivos
{
    public class FluxoDeNumeros
    {
        public List<int> positivo = new List<int>();
        public int[] numeros = new int[15];
        public void Executar()
        {
            MostrarTitulo();
            MostrarCondicao();
            MostrarResultado();
        }
        private void MostrarTitulo()
        {
            Console.WriteLine("#####################################");
            Console.WriteLine("###Segragação de Números Positivos###");
            Console.WriteLine("#####################################");
        }

        private void MostrarCondicao()
        {
            int x = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite 15 números de sua escolha: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                numeros[i] = numero;

                if (numero >= 0)
                {

                    positivo.Add(numero);
                    x = x + 1;
                }
            }
        }

        private void MostrarResultado()
        {
            Console.WriteLine("Os números digitados foram: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("Dentre eles os positivos são: ");

            for (int i = 0; i < positivo.Count; i++)
            {
                Console.WriteLine(positivo[i]);
            }

            Console.ReadKey();
        }
    }
}
