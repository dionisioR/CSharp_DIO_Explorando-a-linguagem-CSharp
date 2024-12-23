using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;
        private T[] _array = new T[capacidade];

        public void AdicionarElementoArray(T elemento)
        {
            if (contador + 1 < 11)
            {
                _array[contador] = elemento;
                contador++;
            }
        }

        public T this[int index]
        {
            get { return _array[index]; }
            set{ _array[index] = value;}
        }
    }
}