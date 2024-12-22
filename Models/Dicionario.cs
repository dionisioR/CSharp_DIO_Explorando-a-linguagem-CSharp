using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Dicionario
    {
        public static void Executar()
        {
            // a chave deve ser um valor único, caso contrário uma exceção será lançada
            // Dictionary<key, value> estado = new Dictionary<string, string>();
            Dictionary<string, string> estado = new Dictionary<string, string>();
            estado.Add("SP", "São Paulo");
            estado.Add("RJ", "Rio de Janeiro");
            estado.Add("MG", "Minas Gerais");
            estado.Add("ES", "Espírito Santo");
            estado.Add("PR", "Paraná");

            Console.WriteLine(estado["SP"]);
            Console.WriteLine(estado["RJ"]);
            Console.WriteLine("------------------------");

            // percorrendo o dicionário
            foreach (var item in estado)
            {
                Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
            }

            // vai gerar erro
            // estado.Add("SP", "São Paulo");
            Console.WriteLine("------------------------");

            // removendo um item
            estado.Remove("PR");
            foreach (var item in estado)
            {
                Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
            }

            Console.WriteLine("------------------------");
            // alterando um item
            estado["SP"] = "Estado de São Paulo";
            foreach (var item in estado)
            {
                Console.WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
            }

            Console.WriteLine("------------------------");
            // verificando se a chave existe
            if (estado.ContainsKey("SP"))
            {
                Console.WriteLine("A chave SP existe");
            }
            else
            {
                Console.WriteLine("A chave SP não existe");
            }

            Console.WriteLine("------------------------");
            // verificando se o valor existe
            if (estado.ContainsValue("São Paulo"))
            {
                Console.WriteLine("O valor São Paulo existe");
            }
            else
            {
                Console.WriteLine("O valor São Paulo não existe");
            }   
            
        }
    }
}