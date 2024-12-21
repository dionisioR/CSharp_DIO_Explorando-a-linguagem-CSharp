using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Globalization;

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class Datas
    {
        public static void Executar()
        {
            // hora do sistema
            DateTime horaAtual = DateTime.Now;
            Console.WriteLine(horaAtual);
            Console.WriteLine(horaAtual.ToString("dd-MM-yyyy"));
            Console.WriteLine(horaAtual.ToString("dd-MM-yyyy HH:mm"));

            // somente a data - data curta
            Console.WriteLine(horaAtual.ToShortDateString());

            // somente a hora - hora curta
            Console.WriteLine(horaAtual.ToShortTimeString());

            // recebendo a data
            DateTime data = new DateTime(2021, 12, 25);
            Console.WriteLine(data);

            data = Convert.ToDateTime("21/12/2024 18:33");
            Console.WriteLine(data);

            // Conversão de maneira segura
            string dataString = "2024-12-21 18:33";
            bool sucesso =  DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataConvertida);
            if (sucesso){
                Console.WriteLine(dataConvertida);
            } else {
                Console.WriteLine("Erro na conversão da data");
            }
        }
    }
}