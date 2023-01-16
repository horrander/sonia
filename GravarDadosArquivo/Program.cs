namespace GravarDadosArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter($"C:{Path.DirectorySeparatorChar}ProjetosAtuais{Path.DirectorySeparatorChar}ProjetosC-{Path.DirectorySeparatorChar}GravarDadosArquivo{Path.DirectorySeparatorChar}Saidas{Path.DirectorySeparatorChar}.Sample.csv");
                //Write a line of text
                sw.WriteLine("Hello World!!");
                //Write a second line of text
                sw.WriteLine("From the StreamWriter class");
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}