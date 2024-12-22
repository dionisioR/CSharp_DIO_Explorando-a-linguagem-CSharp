using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Pilha
    {
        public static void Executar(){

            // pilha de inteiros
            Stack<int> pilha = new Stack<int>();
            pilha.Push(4);
            pilha.Push(10);
            pilha.Push(100);
            pilha.Push(33);

            // percorrendo a pilha
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

            // removendo o topo da pilha
            Console.WriteLine($"Removendo o topo da pilha: {pilha.Pop()}");
            Console.WriteLine($"Removendo o topo da pilha: {pilha.Pop()}");

            // percorrendo a pilha
            foreach (var item in pilha)
            {
                Console.WriteLine(item);
            }

        }
    }
}