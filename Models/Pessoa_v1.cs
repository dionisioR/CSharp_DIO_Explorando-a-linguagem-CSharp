using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Pessoa_V1
    {
        // propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Método 
        public void Apresentar()
        {
            Console.WriteLine($"Nome {Nome} - Idade {Idade}.");
        }
    }
}