using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace practica2.Controllers
{
    public class quienesController : Controller
    {
        public IActionResult quienes()
        {
            return View();
        }
    }
}