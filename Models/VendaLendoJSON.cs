using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;  //<<<<<

namespace CSharp_DIO_Explorando_a_linguagem_CSharp.Models
{
    public class VendaLendoJSON
    {
        public int Id { get; set; }
        // [JsonProperty("Nome_Produto")] //<<<<<
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }
    }
}