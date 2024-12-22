using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class LeituraArquivo
    {
        public static void Executar()
        {
            try
            {
                string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
                foreach (string linha in linhas)
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
                Console.WriteLine("Diretório não encontrado: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            }
            finally{
                Console.WriteLine("Fim da leitura do arquivo");
            }
            Console.WriteLine("Fim do arquivo");
        }
    }
}