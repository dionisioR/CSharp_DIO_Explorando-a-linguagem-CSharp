using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//------------------------
using System.Globalization;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class ValorMonetario
    {
        public static void executar(){
            decimal valor = 10333.5m;
            Console.WriteLine(valor);

            // formatando o valor monetário R$
            // Vai pegar a configuração do sistema
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine($"{valor:C}");

            // formatando o valor monetário US$
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine($"{valor:C}");


        }
    }
}