using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Pessoa_v4
    {
        private string _nome;
        private int _idade;
        // propriedades
        public string Nome {
            get => _nome.ToUpper(); 
            set => _nome = (value == "") ? throw new Exception("Nome não pode ser vazio.") : value;
         }
        public int Idade { 
            get => _idade; 
            set => _idade = (value < 0) ? throw new Exception("Idade não pode ser negativa.") : value;
        }

        // Método 
        public void Apresentar()
        {
            Console.WriteLine($"Nome {Nome} - Idade {Idade}.");
        }
    }
}