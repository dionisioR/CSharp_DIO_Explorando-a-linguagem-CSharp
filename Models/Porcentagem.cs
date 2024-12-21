using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//--------------------------------------------
using  System.Globalization;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Porcentagem
    {
        public static void Executar(){
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            double porcentagem = 34;
            Console.WriteLine(porcentagem.ToString("P"));

            porcentagem = 0.3421;
            Console.WriteLine(porcentagem.ToString("P"));
            Console.WriteLine(porcentagem.ToString("P1"));
            Console.WriteLine(porcentagem.ToString("P2"));
            Console.WriteLine(porcentagem.ToString("P3"));

            Console.WriteLine("---------------");
            // Criando uma formatação personalizada
            int cep = 12500712;
            Console.WriteLine(cep.ToString("##-###-###"));
        }
    }
}