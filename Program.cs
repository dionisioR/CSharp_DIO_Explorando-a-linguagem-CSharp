using CSharp_DIO_Explorando_a_linguagem_CSharp.Models;
using Newtonsoft.Json;

// Porcentagem
// Porcentagem.Executar();
// Console.WriteLine("------------------------");
// valor monetário
// ValorMonetario.executar();
// Console.WriteLine("------------------------");
// ValorMonetario2.executar();
// Console.WriteLine("------------------------");
// Pessoa p1 = new Pessoa();
// p1.Nome = "Anakin";
// p1.Idade = 11;
// p1.Sobrenome = "Skywalker";
// p1.Apresentar();

// Pessoa p1 = new Pessoa("Anakin", "Skywalker");
// p1.Nome = "Anakin";
// p1.Sobrenome = "Skywalker";

// Pessoa p2 = new Pessoa("Luke", "Skywalker");
// p2.Nome = "Luke";
// p2.Sobrenome = "Skywalker";

// Pessoa p3 = new Pessoa(nome: "Leia", sobrenome: "Organa");
// p3.Nome = "Leia";
// p3.Sobrenome = "Organa";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";

// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);

// cursoDeIngles.ListarAlunos();

// Console.WriteLine("------------------------");
// Datas
// Datas.Executar();

// Console.WriteLine("------------------------");
// Console.WriteLine(" Lendo arquivos ");
// Console.WriteLine("------------------------");
// LeituraArquivo.Executar();

// new ExemploExcecao().Metodo1();
// Fila.Executar();
// Pilha.Executar();
// Dicionario.Executar();
// Tuplas.Executar();

// Tuplas t = new Tuplas();
// var (sucesso, linhasArquivo, quantidadeDeLinhas) = t.LeituraArquivo("Arquivos/arquivoLeitura.txt");

// if(sucesso){
//     Console.WriteLine("Quantidade de linhas: " + quantidadeDeLinhas);
//     foreach (var linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }else{
//     Console.WriteLine("Falha ao ler o arquivo");
// }
//----------------------------------------------
// DateTime dataAtual = DateTime.Now;

// Vendas v1 = new Vendas(1, "Caneta", 25.00m, dataAtual);
// string serializado = JsonConvert.SerializeObject(v1);
// Console.WriteLine(serializado);
// Console.WriteLine("------------------------");

// Vendas v2 = new Vendas(2, "Lápis", 5.00m, dataAtual);
// string serializado2 = JsonConvert.SerializeObject(v2,Formatting.Indented);

// // gravando o arquivo serializado em um arquivo .json
// File.WriteAllText("Arquivos/vendas.json", serializado2);

// Console.WriteLine(serializado2);

// Vendas v3 = new Vendas(3, "Borracha", 2.00m, dataAtual);

// // Agrupando as vendas em uma coleção
// List<Vendas> listaVendas = new List<Vendas>();
// listaVendas.Add(v1);
// listaVendas.Add(v2);
// listaVendas.Add(v3);

// // Serializando a lista de vendas
// string serializado3 = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/vendasLista.json", serializado3);
// Console.WriteLine("------------------------");
// Console.WriteLine(serializado3);

//----------------------------------------------
// deserializando um objeto
string conteudoArquivo = File.ReadAllText("Arquivos/vendasLista.json");
List<VendaLendoJSON> vendasDeserializadas = JsonConvert.DeserializeObject<List<VendaLendoJSON>>(conteudoArquivo);
foreach (var item in vendasDeserializadas)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Produto);
    Console.WriteLine(item.Preco);
    Console.WriteLine(item.DataVenda.ToString("dd/MM/yyyy"));
    Console.WriteLine((item.Desconto.HasValue) ? item.Desconto : 0);
    Console.WriteLine("------------------------");
}

//----------------------------------------------
// bool? desejaReceberEmail = null;
// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("Sim, desejo receber e-mails");
// }
// else
// {
//     Console.WriteLine("Não, não desejo receber e-mails");
// }