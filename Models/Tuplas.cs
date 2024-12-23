using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Tuplas
    {
        public static void Executar()
        {
            (int, string, string, decimal) tupla = (32, "Anakin", "Skywalker", 1000.00M);
            Console.WriteLine($"ID: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Salário: {tupla.Item4}");
            Console.WriteLine("------------------------");

            // Outra forma de declarar tuplas
            ValueTuple<int, string, string, decimal> tupla2 = (32, "Anakin", "Skywalker", 1000.00M);
            Console.WriteLine($"ID: {tupla2.Item1}");
            Console.WriteLine($"Nome: {tupla2.Item2}");
            Console.WriteLine($"Sobrenome: {tupla2.Item3}");
            Console.WriteLine($"Salário: {tupla2.Item4}");
            Console.WriteLine("------------------------");

            // Outra forma de declarar tuplas
            var tupla3 = Tuple.Create(32, "Anakin", "Skywalker", 1000.00M);
            Console.WriteLine($"ID: {tupla3.Item1}");
            Console.WriteLine($"Nome: {tupla3.Item2}");
            Console.WriteLine($"Sobrenome: {tupla3.Item3}");
            Console.WriteLine($"Salário: {tupla3.Item4}");
        }

        // Este método vai retornar três informações
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LeituraArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}