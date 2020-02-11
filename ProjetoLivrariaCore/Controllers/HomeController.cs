using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoLivrariaCore.Models;
using System;
using System.Diagnostics;
using System.Linq;

namespace ProjetoLivrariaCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjetoLivrariaCoreContext _context;

        public HomeController(ProjetoLivrariaCoreContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var homeReturn = new HomeReturn();

                var List = _context.Livro.ToList();

                foreach (var item in List)
                {
                    homeReturn.livroUltimo = List.Where(x => x.LivroId == (List.Min(xx => xx.LivroId))).FirstOrDefault();
                    homeReturn.livroBarato = List.Where(x => x.Preco == (List.Min(xx => xx.Preco))).FirstOrDefault();
                    homeReturn.livroNovo = List.Where(x => x.DataPublicacao == (List.Min(xx => xx.DataPublicacao))).FirstOrDefault();

                }


                return View(homeReturn);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Exception("Erro não identificado"));
        }
    }
}
