using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoLivrariaCore.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLivrariaCore
{
    public class LivrosController : Controller
    {
        private readonly ProjetoLivrariaCoreContext _context;
        private string path = AppDomain.CurrentDomain.BaseDirectory + "..\\..\\..\\wwwroot\\images\\CapasLivros\\";

        public LivrosController(ProjetoLivrariaCoreContext context)
        {
            _context = context;
        }

        // GET: Livros
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Livro.ToListAsync());
        //}

        public async Task<IActionResult> Index(string sortOrder)
        {
            try
            {
                ViewData["AutorSortParm"] = String.IsNullOrEmpty(sortOrder) ? "autor_desc" : "";
                ViewData["IsbnSortParm"] = sortOrder == "isbn" ? "DtPublicSortParm" : "isbn";
                ViewData["NomeSortParm"] = sortOrder == "nome" ? "nome_desc" : "nome";
                ViewData["PrecoSortParm"] = sortOrder == "preco" ? "preco_desc" : "preco";
                ViewData["DtPublicSortParm"] = sortOrder == "dtPublic" ? "dtPublic_desc" : "dtPublic";
                ViewData["sortDescAsc"] = (!string.IsNullOrEmpty(sortOrder) && sortOrder.IndexOf("desc") > -1 ? "glyphicon glyphicon-triangle-top" : "glyphicon glyphicon-triangle-bottom");

                var livros = from l in _context.Livro
                             select l;
                switch (sortOrder)
                {
                    case "autor_desc":
                        livros = livros.OrderByDescending(s => s.Autor);
                        ViewData["sortType"] = "Autor";
                        break;
                    case "nome_desc":
                        livros = livros.OrderByDescending(s => s.Nome);
                        ViewData["sortType"] = "Nome";
                        break;
                    case "nome":
                        livros = livros.OrderBy(s => s.Nome);
                        ViewData["sortType"] = "Nome";
                        break;
                    case "isbn_desc":
                        livros = livros.OrderByDescending(s => s.ISBN);
                        ViewData["sortType"] = "ISBN";
                        break;
                    case "isbn":
                        livros = livros.OrderBy(s => s.ISBN);
                        ViewData["sortType"] = "ISBN";
                        break;
                    case "preco_desc":
                        livros = livros.OrderByDescending(s => s.Preco);
                        ViewData["sortType"] = "Preco";
                        break;
                    case "preco":
                        livros = livros.OrderBy(s => s.Preco);
                        ViewData["sortType"] = "Preco";
                        break;
                    case "dtPublic_desc":
                        livros = livros.OrderByDescending(s => s.DataPublicacao);
                        ViewData["sortType"] = "DataPublicacao";
                        break;
                    case "dtPublic":
                        livros = livros.OrderBy(s => s.DataPublicacao);
                        ViewData["sortType"] = "DataPublicacao";
                        break;
                    default:
                        livros = livros.OrderBy(s => s.Autor);
                        ViewData["sortType"] = "Autor";
                        break;
                }

                return View(await livros.AsNoTracking().ToListAsync());
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var livro = await _context.Livro
                    .FirstOrDefaultAsync(m => m.LivroId == id);
                if (livro == null)
                {
                    return NotFound();
                }

                return View(livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // GET: Livros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LivroId,ISBN,Autor,Nome,Preco,DataPublicacao,CapaLivro")] Livro livro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newNameFile = String.Concat(livro.ISBN.ToString(), livro.CapaLivro.ContentType.Replace("image/", "."));
                    var fileStream = new FileStream(@Path.Combine(path, newNameFile), FileMode.Create, FileAccess.Write);
                    livro.CapaLivro.OpenReadStream().CopyTo(fileStream);
                    fileStream.Dispose();
                    livro.PathCapaLivro = newNameFile;

                    _context.Add(livro);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var livro = await _context.Livro.FindAsync(id);

                if (livro == null)
                {
                    return NotFound();
                }
                return View(livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // GET: Livros/EditISBN/5
        [Route("Livros/EditISBN/{isbn?}")]
        public IActionResult EditISBN(int? isbn)
        {
            try
            {
                if (isbn == null)
                {
                    return NotFound();
                }

                var livro = _context.Livro.Where(x => x.ISBN == isbn).FirstOrDefault();

                if (livro == null)
                {
                    return NotFound();
                }
                return View("Edit", livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LivroId,ISBN,Autor,Nome,Preco,DataPublicacao,CapaLivro,PathCapaLivro")] Livro livro)
        {
            try
            {
                if (id != livro.LivroId)
                {
                    return NotFound();
                }

                if (livro.CapaLivro != null)
                {
                    try
                    {
                        if (System.IO.File.Exists(@Path.Combine(path, livro.PathCapaLivro))) System.IO.File.Delete(@Path.Combine(path, livro.PathCapaLivro));

                        var newNameFile = String.Concat(livro.ISBN.ToString(), livro.CapaLivro.ContentType.Replace("image/", "."));
                        var fileStream = new FileStream(@Path.Combine(path, newNameFile), FileMode.Create, FileAccess.Write);
                        livro.CapaLivro.OpenReadStream().CopyTo(fileStream);
                        fileStream.Dispose();
                        livro.PathCapaLivro = newNameFile;
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                    return RedirectToAction(nameof(Index));
                }
                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(livro);
                        await _context.SaveChangesAsync();

                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!LivroExists(livro.LivroId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var livro = await _context.Livro
                    .FirstOrDefaultAsync(m => m.LivroId == id);
                if (livro == null)
                {
                    return NotFound();
                }

                return View(livro);
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        // POST: Livros/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var livro = _context.Livro.Find(id);
                _context.Livro.Remove(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("Error", ex);
            }
        }

        [HttpPost]
        public bool ConsultaISBN(int isbn)
        {
            return _context.Livro.Any(e => e.ISBN == isbn);
        }

        private bool LivroExists(int id)
        {
            return _context.Livro.Any(e => e.LivroId == id);
        }
    }
}
