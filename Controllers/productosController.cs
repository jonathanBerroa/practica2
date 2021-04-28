using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace practica2.Controllers
{
    public class productosController : Controller
    {
        public IActionResult Producto()
        {
            return View();
        }
    }
}