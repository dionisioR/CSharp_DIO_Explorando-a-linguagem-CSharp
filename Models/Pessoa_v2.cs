using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Pessoa_v2
    {
        private string _nome;
        // propriedades
        public string Nome {
            get { return _nome.ToUpper(); }
            set{
                if(value == ""){
                    throw new Exception("Nome não pode ser vazio.");
                }
                _nome = value;
            }
         }
        public int Idade { get; set; }

        // Método 
        public void Apresentar()
        {
            Console.WriteLine($"Nome {Nome} - Idade {Idade}.");
        }
    }
}