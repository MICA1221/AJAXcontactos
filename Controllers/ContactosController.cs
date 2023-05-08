using Microsoft.AspNetCore.Mvc;
using AJAXContactos.Models;
using System.Collections.Generic;
using global::AJAXContactos.Models;

namespace AJAXContactos.Controllers
{
    public class ContactosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ObtenerContactos()
        {
            List<Contacto> contactos = new List<Contacto>
            {
                new Contacto { Id = 1, Nombre = "Juan Pérez", Telefono = "555-1234", Email = "juan@ejemplo.com" },
                new Contacto { Id = 2, Nombre = "María García", Telefono = "555-5678", Email = "maria@ejemplo.com" },
            };

            return Json(contactos);
        }
    }
}