using System.Runtime.Serialization.Formatters;
using System.Linq;

namespace IdentificadorDeIdade
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var pessoa = new FluxoPessoa();
            pessoa.Executar();
        }

    }

}