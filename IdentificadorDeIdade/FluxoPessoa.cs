using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificadorDeIdade
{
    public class FluxoPessoa
    {
        public String[] nomes = new string[10];
        public List<int> idades = new List<int>();
        public void Executar()
        {
            Titulo();
            Condicional();
            Resultado();
        }
        private void Titulo()
        {
            Console.WriteLine("##################################");
            Console.WriteLine("###Identificação de Senioridade###");
            Console.WriteLine("##################################");
        }

        private void Condicional()
        {
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Informe o nome da pessoa: ");
                nomes[i] = (Console.ReadLine());
                Console.WriteLine("Informe a idade dessa pessoa: ");
                idades.Add(Convert.ToInt32(Console.ReadLine()));

            }
        }

        private void Resultado()
        {
            int maiorIdade = idades.Max();
            int indexListaIdades = idades.IndexOf(maiorIdade);
            Console.WriteLine($"A pessoa mais velha digitada é: {nomes[indexListaIdades]}");

            Console.ReadKey();
        }
    }
}
