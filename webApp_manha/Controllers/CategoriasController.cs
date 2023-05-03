using Microsoft.AspNetCore.Mvc;
using webApp_manha;
using webApp_manha.Entidade;

namespace webApp_manha.Controllers
{
    public class CategoriasController : Controller
    {
        private Contexto db;
        public CategoriasController(Contexto _db)
        {
            this.db = _db;
        }

        public IActionResult Lista()
        {
            return View(db.Categorias.ToList());
        }

        [HttpPost]
        public IActionResult Cadrasto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(Categorias dados)
        {
            db.Categorias.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
