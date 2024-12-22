using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class ExemploExcecao
    {
        public void Metodo1(){
            Console.WriteLine("Inicio do Metodo1");
            Metodo2();
        }
        public void Metodo2(){
            Console.WriteLine("Inicio do Metodo2");
            Metodo3();
        }
        public void Metodo3(){
            Console.WriteLine("Inicio do Metodo3");
            Metodo4();
        }
        public void Metodo4(){
            Console.WriteLine("Inicio do Metodo4");
            throw new Exception("Ocorreu uma exceção!");
        }
    }
}