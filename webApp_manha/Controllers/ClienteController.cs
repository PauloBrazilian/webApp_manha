using Microsoft.AspNetCore.Mvc;

namespace webApp_manha.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
