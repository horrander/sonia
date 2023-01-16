using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDeNotas
{
    public class Fluxo
    {
        public string NomeAluno { get; set; }
        public Double Nota1 { get; set; }
        public Double Nota2 { get; set; }
        public Double MediaNota {get; set;}
        public void Executar()
        {
            MostrarTitulo();
            ReceberNotas();
            CacularMedia();
            CondicaoAprovacao();
        }

        private void MostrarTitulo()
        {
            Console.WriteLine("###Programa Média de Notas###");
        }
        
        private void ReceberNotas()
        {
            Console.WriteLine("Informe o nome do aluno: ");
            NomeAluno = (Console.ReadLine());

            Console.WriteLine("Informe a nota da primera prova: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

        }

        private void CacularMedia()
        {
            
            MediaNota = (Nota1 + Nota2) / 2;
        }

        private void CondicaoAprovacao()
        {
            if (MediaNota < 7)
            {
                Console.WriteLine($"O(a) aluno(a) {NomeAluno} foi reprovado(a) por obter nota abaixo de 70%: nota {MediaNota}");

            }
            else
            {
                Console.WriteLine($"O(a) aluno(a) {NomeAluno} foi aprovado(a) por obter nota necessária para aprovação: nota {MediaNota}");
            }

            Console.ReadKey();
        }

    }

   

      
    


}
