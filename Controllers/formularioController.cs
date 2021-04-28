using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace practica2.Controllers
{
    public class formularioController : Controller

    {

        public IActionResult formulario()
        {
            return View();
        }
    }
}