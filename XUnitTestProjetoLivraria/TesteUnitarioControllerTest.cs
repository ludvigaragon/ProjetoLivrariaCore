using Microsoft.EntityFrameworkCore;
using ProjetoLivrariaCore;
using ProjetoLivrariaCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Moq;
using System.IO;
using System.Threading;
using System.Net;

namespace XUnitTestProjetoLivraria
{
    public class TesteUnitarioControllerTest
    {
        private string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\imageTest\\";
        public ProjetoLivrariaCoreContext GetDbContext()
        {
            var options = new DbContextOptionsBuilder<ProjetoLivrariaCoreContext>()
                            .UseInMemoryDatabase(databaseName: "InMemoryArticleDatabase")
                            .Options;
            var dbContext = new ProjetoLivrariaCoreContext(options);

            return dbContext;
        }
        private ProjetoLivrariaCoreContext _context;
        LivrosController _controller;
        TesteUnitarioLivros _service;
        public TesteUnitarioControllerTest()
        {
            _service = new TesteUnitarioLivros();

            _context = GetDbContext();

            if (_context.Livro.Find(1) == null)
            {
                foreach (var livro in _service.GetAllItems())
                {
                    _context.Livro.Add(livro);
                }
                _context.SaveChanges();
            }
            _controller = new LivrosController(_context);
        }
        [Fact]
        public void Get_RetornoOK()
        {
            // Act
            var okResult = _controller.Index(string.Empty);
            // Assert
            Assert.IsType<ViewResult>(okResult.Result);
        }
        [Fact]
        public void Get_RetornoListaCompleta()
        {
            var result = _controller.Index(string.Empty).GetAwaiter().GetResult();
            _context.Dispose();
            // Act
            var viewResult = Assert.IsType<ViewResult>(result);
            //Assert
            var model = Assert.IsAssignableFrom<List<Livro>>(
                viewResult.ViewData.Model);
            Assert.True(model.Count >= 5);
        }

        [Fact]
        public void Get_ConsultaDetalhes()
        {
            var result = _controller.Details(1).GetAwaiter().GetResult();
            _context.Dispose();
            // Act
            var viewResult = Assert.IsType<ViewResult>(result);
            //Assert
            var model = Assert.IsAssignableFrom<Livro>(
                viewResult.ViewData.Model);
            Assert.NotNull(model);
        }

        [Fact]
        public void Set_InsereRegistro()
        {
            var file = new Mock<IFormFile>();
            var sourceImg = File.OpenRead(path + @"wallpaper.jpg");
            var ms = new MemoryStream();
            var writer = new StreamWriter(ms);
            writer.Write(sourceImg);
            writer.Flush();
            ms.Position = 0;
            var fileName = "image.jpg";
            file.Setup(f => f.FileName).Returns(fileName).Verifiable();
            file.Setup(f => f.ContentType).Returns("image/jpeg").Verifiable();
            file.Setup(f => f.OpenReadStream()).Returns(sourceImg).Verifiable();
            file.Setup(_ => _.CopyToAsync(It.IsAny<Stream>(), It.IsAny<CancellationToken>()))
                .Returns((Stream stream, CancellationToken token) => ms.CopyToAsync(stream))
                .Verifiable();
            var inputFile = file.Object;

            var livro = new Livro() { LivroId = 6, Autor = "Autor Seis", DataPublicacao = new DateTime(2020, 01, 01), ISBN = 1116, Nome = "Livro 6", PathCapaLivro = "1116.jpg", Preco = 90.90M, CapaLivro = inputFile };
            var result = _controller.Create(livro).GetAwaiter().GetResult();
            _context.SaveChanges();
            _context.Dispose();
            // Act
            var viewResult = Assert.IsType<RedirectToActionResult>(result);
            //Assert
            Assert.True(viewResult.ActionName == "Index");

        }

        [Fact]
        public async void Set_AtualizaRegistro()
        {
            var resultLivro = _controller.Details(1).Result;
            var viewResultLivro = Assert.IsType<ViewResult>(resultLivro);
            var model = Assert.IsAssignableFrom<Livro>(
                viewResultLivro.ViewData.Model);

            var result = await _controller.Edit(1, model);
            _context.SaveChanges();
            _context.Dispose();
            // Act
            var viewResult = Assert.IsType<RedirectToActionResult>(result);
            //Assert
            Assert.True(viewResult.ActionName == "Index");
        }

        [Fact]
        public async void Set_DeleteRegistro()
        {
            var result = await _controller.DeleteConfirmed(1);

            // Act
            var viewResult = Assert.IsType<RedirectToActionResult>(result);
            //Assert
            Assert.True(viewResult.ActionName == "Index");
        }
    }
}
