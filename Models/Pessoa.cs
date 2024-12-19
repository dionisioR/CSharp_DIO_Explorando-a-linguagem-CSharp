using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        // propriedades
        public string Nome
        {
            get => _nome.ToUpper();
            set => _nome = (value == "") ? throw new Exception("Nome não pode ser vazio.") : value;
        }
        public string Sobrenome { get; set; }

        // Propriedade somente leitura
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;
            set => _idade = (value < 0) ? throw new Exception("Idade não pode ser negativa.") : value;
        }

        // Método 
        public void Apresentar()
        {
            Console.WriteLine($"Nome {NomeCompleto} - Idade {Idade}.");
        }
    }
}