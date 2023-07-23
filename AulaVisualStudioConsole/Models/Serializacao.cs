using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaVisualStudioConsole.Models
{
    public class Serializacao
    {
        public Serializacao() { }
        public Serializacao(int id, string produto, decimal preco, DateTime dataatual)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataatual;
            Desconto = null;
        }

        public int Id { get; set; }
       // [JsonProperty("NomeDoProduto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }

        public string CriarJson()
        {
            List<Serializacao> list = new List<Serializacao>();
            decimal valor = 100;
            Serializacao venda1 = new Serializacao(1, "Cebolinha", valor, DateTime.Now);
            Serializacao venda2 = new Serializacao(2, "Salsinha", 50.00M, DateTime.Now);

            list.Add(venda1);
            list.Add(venda2);


            //serializar em json
            string serializando = JsonConvert.SerializeObject(list, Formatting.Indented);
            Console.WriteLine(serializando);
            return serializando;

        }

        public void SerializarArquivo()
        {
            string caminho = "C://Amauri//Projeto//Formação .NET Developer//Fundamentos .Net//C#//AulaVisualStudioConsole//AulaVisualStudioConsole//Arquivo//json.txt";
            string json = CriarJson();
            File.WriteAllText(caminho, json);


            DeserializarArquivo();
        }

        public void DeserializarArquivo()
        {
            string caminho = "C://Amauri//Projeto//Formação .NET Developer//Fundamentos .Net//C#//AulaVisualStudioConsole//AulaVisualStudioConsole//Arquivo//json.txt";
            string arquivo = File.ReadAllText(caminho);

            List<Serializacao> lista = JsonConvert.DeserializeObject<List<Serializacao>>(arquivo);
            foreach (var item in lista)
            {
                Console.WriteLine($"DeserializarArquivo: Id: {item.Id}, Produto: {item.Produto}, preço: {item.Preco}, " +
                                  $"dia: {item.DataVenda.ToString("dd/MM/yyyy HH:mm")} " +
                                  $", desconto: {(Desconto.HasValue ? $"de {item.Desconto}" : "0")}");
            }

            ObjetoAnonimo(lista);
        }

        public void ObjetoAnonimo(List<Serializacao> lista)
        {
            var listaAnonima = lista.Select(x => new { x.Produto, x.Preco });
            foreach (var item in listaAnonima)
            {
                Console.WriteLine($"...................... ................................................");
                Console.WriteLine($"Objeto aninimo: Produto: {item.Produto}, preço: {item.Preco} ");
            }
        }
    }
}
