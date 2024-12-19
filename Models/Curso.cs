using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }
        public bool RemoverAlunp(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Alunos do curso de {Nome}:");
            Console.WriteLine("-------------------------");

            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}