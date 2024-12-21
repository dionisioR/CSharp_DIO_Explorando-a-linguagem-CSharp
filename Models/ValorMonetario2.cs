using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//------------------------
using System.Globalization;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class ValorMonetario2
    {
        public static void executar()
        {

            // formatando o valor monetário US$
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            decimal valor = 10333.5m;
            Console.WriteLine(valor);

            // formatando o valor monetário R$
            // Vai pegar a configuração do sistema
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine($"{valor:C}");

            // Formatando o valor monetário US$
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine("------------------------");
            // Moeda - Casas decimais
            Console.WriteLine($"{valor:C}");
            Console.WriteLine($"{valor:C1}");
            Console.WriteLine($"{valor:C2}");
            Console.WriteLine($"{valor:C3}");
            // Número - Casas decimais
            Console.WriteLine($"{valor:N}");
            Console.WriteLine($"{valor:N1}");
            Console.WriteLine($"{valor:N2}");
            Console.WriteLine($"{valor:N3}");

        }
    }
}