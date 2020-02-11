using Microsoft.EntityFrameworkCore;
using ProjetoLivrariaCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XUnitTestProjetoLivraria
{
    public class TesteUnitarioLivros
    {
        private readonly List<Livro> _livros;
        public TesteUnitarioLivros()
        {
            _livros = new List<Livro>()
            {
                new Livro() { LivroId = 1, ISBN = 1111, Nome = "Livro 1", Autor ="Autor Um", Preco = 50.50M, DataPublicacao = new DateTime(2020,05,20), PathCapaLivro= "1111.jpg"},
                new Livro() { LivroId = 2, ISBN = 1112, Nome = "Livro 2", Autor ="Autor Dois", Preco = 60.50M, DataPublicacao = new DateTime(2019,05,21), PathCapaLivro= "1112.jpg"},
                new Livro() { LivroId = 3, ISBN = 1113, Nome = "Livro 3", Autor ="Autor Tres", Preco = 70.50M, DataPublicacao = new DateTime(2018,05,22), PathCapaLivro= "1113.jpg"},
                new Livro() { LivroId = 4, ISBN = 1114, Nome = "Livro 4", Autor ="Autor Quatro", Preco = 80.50M, DataPublicacao = new DateTime(2017,05,23), PathCapaLivro= "1114.jpg"},
                new Livro() { LivroId = 5, ISBN = 1115, Nome = "Livro 5", Autor ="Autor Cinco", Preco = 90.50M, DataPublicacao = new DateTime(2016,05,24), PathCapaLivro= "1115.jpg"},
            };
        }
        public IEnumerable<Livro> GetAllItems()
        {
            return _livros;
        }
        public Livro Add(Livro novoItem)
        {
            novoItem.LivroId = GeraId();
            _livros.Add(novoItem);
            return novoItem;
        }
        public Livro GetById(int id)
        {
            return _livros.Where(a => a.LivroId == id)
                .FirstOrDefault();
        }
        public void Remove(int id)
        {
            var item = _livros.First(a => a.LivroId == id);
            _livros.Remove(item);
        }
        static int GeraId()
        {
            Random random = new Random();
            return random.Next(1, 100);
        }
    }
}

