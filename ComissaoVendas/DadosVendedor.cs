using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComissaoVendas
{
    public class DadosVendedor
    {

        public String NomeDoVendedor { get; set; }
        public double SalarioFixoDoVendedor {get; set;}
        public double ValorTotalDeVendasEfetuadas { get; set;}
        public double CalculoTotalDeGanhosMensal { get; set; }
        public void Executar()
        {
            MostrarCabecalho();
            ColetarInforcacoesVendedor();
            CalcularComissao();
            ResultadoDoCalculo();

        }
        private void MostrarCabecalho()
        {
            Console.WriteLine("#########################");
            Console.WriteLine("Cálculo de Ganho de um Vendedor");
            Console.WriteLine("#########################");
        }
        private void ColetarInforcacoesVendedor()
        {
          
            Console.WriteLine("Informe o nome do vendedor em questão");
            NomeDoVendedor = (Console.ReadLine());

            Console.WriteLine($"Qual é o salário fixo do(a) vendedor(a) {NomeDoVendedor}");
            SalarioFixoDoVendedor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Informe o valor total que o  {NomeDoVendedor}  realizou neste mês");
            ValorTotalDeVendasEfetuadas = Convert.ToDouble(Console.ReadLine());
        }
        private void CalcularComissao()
        {
            CalculoTotalDeGanhosMensal = (ValorTotalDeVendasEfetuadas * 0.15) + SalarioFixoDoVendedor;
        }
        private void ResultadoDoCalculo()
        {
            Console.WriteLine($"O(a) vendedor(a) {NomeDoVendedor}, cujo salário mensal é de {SalarioFixoDoVendedor}, " +
                $"receberá o valor total de {CalculoTotalDeGanhosMensal}, já somadas as comissões das vendas realizadas esse mês. ");

            Console.ReadKey();
        }
        

    }
}
