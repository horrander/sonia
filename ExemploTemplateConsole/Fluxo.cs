using ExemploTemplateConsole.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTemplateConsole
{
    internal class Fluxo
    {
        public void Executar()
        {
            //declarei variável do ripo pessoa
            //nomeei a variável como
            //inicializei usando o igual
            //recebendo o valor instanciando através do new
            //que o new instanciou a classe pessoa
            //fiz com que a variável pessoa tenha todos os atributos
            Pessoa pessoa = new Pessoa();

            //quando coloco o nome da variável
            //Que eu instanciei um objeto (classe)
            //através do . eu consigo acessar e modificar os
            //atributos que tem na classe
            //ou seja o nome que está dentro de class Pessoa{}
            //public string Cpf { get; set; }
            //porque está público eu consigo acessar ele aqui
            pessoa.Nome = "Sônia";

            //aqui eu converti uma data para datetime
            //vou informar uma data de niver fake
            //para fingir ser meu niver
            pessoa.Nascimento = DateTime.Parse("2010-02-01");

            TimeSpan tempoEntreDatas = DateTime.Now - pessoa.Nascimento;

            DateTime quantosAnosTem = new DateTime(tempoEntreDatas.Ticks);

            int quantidadeAnos = quantosAnosTem.Year;

            if(quantidadeAnos < 18)
            {
                Console.WriteLine("Menor de Idade");
            }
            else
            {
                Console.WriteLine("Maior de Idade");
            }
        }    
    }
  }
       