using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Fila
    {
        public static void Executar(){
            // fila de inteiro
            Queue<int> fila = new Queue<int>();

            // Adicionando elementos na fila
            fila.Enqueue(11);
            fila.Enqueue(2);
            fila.Enqueue(34);
            fila.Enqueue(54);

            // Exibindo elementos da fila
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            // Removendo elementos da fila
            Console.WriteLine($"Removendo elementos da fila: {fila.Dequeue()}");
            Console.WriteLine($"Removendo elementos da fila: {fila.Dequeue()}");
            Console.WriteLine("------------------------");

            // Exibindo elementos da fila
            foreach (var item in fila)
            {
                Console.WriteLine(item);
            }
        }
    }
}