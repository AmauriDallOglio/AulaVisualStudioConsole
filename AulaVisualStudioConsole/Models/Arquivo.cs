using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Arquivo
    {

        public string Id { get; set; }

        public void LendoArquivo()
        {



            //C:\Amauri\Projeto\Formação .NET Developer\Fundamentos .Net\C#\AulaVisualStudioConsole\AulaVisualStudioConsole\Arquivo
            var erro = 1;
            try
            {
                string[] linhas = File.ReadAllLines("C://Amauri//Projeto//Formação .NET Developer//Fundamentos .Net//C#//AulaVisualStudioConsole//AulaVisualStudioConsole//Arquivo//ArquivoLeitura.txt");
                foreach (var linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo não encontrado: " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Diretorio não encontrado: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Arquivo lido");
            }
        }
    }
}
