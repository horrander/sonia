using System.Reflection;

namespace MediaDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fluxo = new Fluxo();
            fluxo.Executar();

            Console.ReadKey();
        }

    }
}