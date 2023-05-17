using Microsoft.AspNetCore.Mvc;
using webApp_manha.Entidade;

namespace webApp_manha.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto contexto) { 
            db = contexto;       
        }


        public IActionResult Lista() 
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View(model);
        }


        [HttpPost]
        public IActionResult SalvarDados(Produtos dados) 
        {
            db.Produtos.Add(dados);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }

    }
}
