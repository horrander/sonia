namespace NovoProjetoPetShop.Repositorios
{
    public class LerGravarArquivos
    {
        //Windows
        //String caminho = "C:\\ProjetosAtuais\\ProjetosC-\\NovoProjetoPetShop\\base_de_dados.csv";
        //Linux
        string caminho = "/app/ProjetosC-/NovoProjetoPetShop/base_de_dados.csv";

        public void GravarArquivosCsv(List<string> conteudo)
        {
            //Valores que não serão alterados devem ser constantes
            const string cabecalho = "NOME;CPF;DATA DE NASCIMENTO;NOME PET;DATA_ALTERACAO;DATA_EXCLUSAO";

            try
            {
                StreamWriter arquivo = new StreamWriter(caminho);

                arquivo.WriteLine(cabecalho);

                //Pra validar se existe um item em uma lista é melhor usar o método Any() do que o Count() == 0,
                //pois o mesmo não irá percorrer todas as linhas do array para contar quantos itens ele tem
                //melhorando a performance
                if (conteudo.Any())
                {
                    // arquivo.WriteLine(conteudo);
                    //Isso não irá funcionar, pois o método WriteLine escreve uma linha por vez, se vc passar uma lista pra ele
                    //o que será escrito é o nome do tipo de dados, 
                    //NOME;CPF;DATA DE NASCIMENTO;NOME PET;DATA_ALTERACAO;DATA_EXCLUSAO
                    //System.Collections.Generic.List`1[System.String]

                    foreach (var item in conteudo)
                    {
                        //É necessário escrever uma linha por vez
                        arquivo.WriteLine(item);
                    }

                    //Uma forma mais simples de trabalhar com arquivos é usar a classe nativa do c# File
                    //Seria mais simples assim, pois não é necessário usar um stream de dados, ele abstrai tudo pra vc
                    //File.WriteAllLines(caminho, conteudo);
                }

                arquivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            //Este método possui um problema de lógica, toda vez ele vai sobrescrever os clientes existentes e salvar um novo,
            //Vc vai ter sempre um único cliente, nesse caso, antes de inserir vc precisa chamar o método de ler e apenas acrescentar o cliente novo
            //no final, e depois salvar
        }

        public List<String> LerArquivosCsv()
        {
            StreamReader file;
            try
            {
                List<String> conteudo = new List<String>();
                if (caminho == null || caminho == "")
                {
                    caminho = "C:\\ProjetosAtuais\\ProjetosC-\\NovoProjetoPetShop\\base_de_dados.csv";
                }
                file = new StreamReader(caminho);
                string? line;

                while ((line = file.ReadLine()) != null)
                {
                    conteudo.Add(line);
                    line = line;
                    Console.WriteLine(line);
                }
                file.Close();
                return conteudo;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return null;

            }


        }


    }

}



