using Microsoft.AspNetCore.Mvc;
using webApp_manha.Models;

namespace webApp_manha.Controllers
{
    public class ClienteController : Controller
    {

        public static List<ClienteViewModel> lista = new List<ClienteViewModel>();
        public IActionResult Lista()
        {   
            //for (int i = 0; i <= 45; i++)
            //{
            //    ClienteViewModel novo = new ClienteViewModel();
            //    novo.Nome = "Paulo " + i;
            //    novo.Id = 1+i;
            //    novo.Telefone = "2456098";
            //    lista.Add(novo);
            //}

            return View(lista);
        }


        [HttpPost]
        public IActionResult SalvarDados(PermissaoController model) 
        {
            if (model.Id > 0)
            {
                int indice = lista.FindIndex(a => a.Id == model.Id);
                lista[indice] = model;
            }
            else 
            {
                Random radom = new Random();
                model.Id = radom.Next(1, 9999);
                lista.Add(model);
            }

            
            lista.Add(model);
            return RedirectToAction("Lista");
            
        }


        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome)) 
            {
                TempData["Erro"] = "o Campo nome não pode estar em branco";
            }

            if (string.IsNullOrEmpty(Telefone)) 
            {
                TempData["Erro"] = "O campo Telefone não pode estar em branco";
            }

            return View();
        }

        public IActionResult Editar(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null)
            {
                return View(cliente);
            }
            else {
                return RedirectToAction("lista");
            }
        }

        public IActionResult Excluir(int id)
        {
            ClienteViewModel cliente = lista.Find(a => a.Id == id);
            if (cliente != null) 
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista");

        }

        public IActionResult Comprass(int id)
        {
            return View();
        }



    }
}
