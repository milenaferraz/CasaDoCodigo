using CasaDoCodigo.Models;
using CasaDoCodigo.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static CasaDoCodigo.Repository.ProdutoRepository;

namespace CasaDoCodigo
{
     public class DataService : IDataService
     {
        private readonly ApplicationContext context;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext context, IProdutoRepository produtoRepository)
        {
            this.context = context;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB()
        {
            context.Database.Migrate();

            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }

            private static List<Livro> GetLivros()
            {
                var json = File.ReadAllText("livros.json");
                var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
                return livros;
            }

        
     }  
}

