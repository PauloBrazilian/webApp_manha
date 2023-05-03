using Microsoft.AspNetCore.Mvc;
using webApp_manha.Entidade;

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
            return View(contexto.Permissaos.ToList());
        }

        public IActionResult Cadrasto() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(PermissaoEntidade dados) 
        {
            contexto.Permissaos.Add(dados);
            contexto.SaveChanges();
            return RedirectToAction("Lista");  
        }
    }
}
