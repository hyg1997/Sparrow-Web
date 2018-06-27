using Sparrow_Delivery.Helpers;
using Sparrow_Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparrow_Delivery.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario)
        {
            using (var db = new SparrowModel())
            {
                var aux = db.Usuario.FirstOrDefault(x => x.email == usuario.email && x.password == usuario.password);
                if (aux != null)
                {
                    SessionHelpers.userID = aux.Id;
                    SessionHelpers.nombre = aux.nombre;
                    return RedirectToAction("Index","Producto");
                }
                ModelState.AddModelError("notFound", "Email y/o contraseña incorrectos");
            }

            return View(usuario);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Usuario usuario)
        {
            using (var db = new SparrowModel())
            {
                if (ModelState.IsValid)
                {
                    var aux = db.Usuario.FirstOrDefault(x => x.email == usuario.email);
                    if (aux == null)
                    {
                        db.Usuario.Add(usuario);
                        db.SaveChanges();
                        return RedirectToAction("Login");
                    }
                    ModelState.AddModelError("noDisponible", "Email ya registrado");
                }
            }
            return View(usuario);
        }
    }
}