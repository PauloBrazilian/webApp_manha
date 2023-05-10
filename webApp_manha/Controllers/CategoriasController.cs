using Microsoft.AspNetCore.Mvc;
using webApp_manha;
using webApp_manha.Entidade;
using webApp_manha.Models;

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
        public IActionResult SalvarDados(CategoriaViewModel dados)
        {
            Categorias entidade = new Categorias();
            entidade.NOME = dados.Nome;
            entidade.ID = dados.Id;
            //entidade.Ativo = dados.Ativo == "on" ? true : false;
            entidade.ATIVO = dados.Ativo;

            if (entidade.ID > 0)
            {
                db.Categorias.Update(entidade);
                db.SaveChanges();
            }
            else 
            {
                db.Categorias.Add(entidade);
                db.SaveChanges();
            }
            
            
            
            
            
            
            
            
            
            db.Categorias.Add(entidade);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }

        public IActionResult Excluir(int id)
        {
            Categorias item = db.Categorias.Find(id);

            if (item == null)
            {
                db.Categorias.Remove(item);
                db.SaveChanges();
            }

            return RedirectToAction("Lista");
        }
    
        public IActionResult Editar (int id) 
        {
            Categorias item = db.Categorias.Find (id);

            if (item == null)
            {
                return View(item);
            }
            else 
            {
                return RedirectToAction("Lista");
            }
        }
    
    }
}
