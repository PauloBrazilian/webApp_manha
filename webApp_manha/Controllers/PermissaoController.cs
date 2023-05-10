using Microsoft.AspNetCore.Mvc;
using webApp_manha.Entidade;
using webApp_manha.Models;

namespace webApp_manha.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto contexto;

        public PermissaoController(Contexto db) 
        {
            contexto = db;
        }

        public IActionResult Lista()
        {
            return View(contexto.Permissao.ToList());
        }

        public IActionResult Cadrasto() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(PermissaoEntidade dados) 
        {
            contexto.Permissao.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");  
        }
    }
}
