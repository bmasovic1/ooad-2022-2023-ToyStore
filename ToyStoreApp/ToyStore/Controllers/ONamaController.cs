using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ToyStore.Controllers
{
    public class ONamaController : Controller
    {
        // GET: ONama
        public ActionResult ONama()
        {
            return View("ONama");
        }
    }
}

