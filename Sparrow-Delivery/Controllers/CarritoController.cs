using Sparrow_Delivery.Helpers;
using Sparrow_Delivery.Models;
using Sparrow_Delivery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparrow_Delivery.Controllers
{
    public class CarritoController : Controller
    {

        // GET: Carrito
        public ActionResult Index()
        {
            if (SessionHelpers.carrito == null)
            {
                SessionHelpers.carrito = new List<Item>();
            }
            return View();
        }

        public ActionResult Agregar(int ID)
        {
            Producto producto;
            using (var db = new SparrowModel())
            {
                producto = db.Producto.FirstOrDefault(x => x.Id == ID);
                if (SessionHelpers.carrito == null)
                {
                    SessionHelpers.carrito = new List<Item>();
                }
                Item aux = SessionHelpers.carrito.FirstOrDefault(x => x.producto.Id == ID);
                if (aux != null)
                {
                    foreach (var item in SessionHelpers.carrito)
                    {
                        if (item.producto.Id == ID)
                        {
                            item.cantidad++;
                        }
                    }
                }
                else
                {
                    SessionHelpers.carrito.Add(new ViewModels.Item
                    {
                        producto = producto,
                        cantidad = 1
                    });
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Eliminar(int ID)
        {
            var aux = SessionHelpers.carrito.FirstOrDefault(x => x.producto.Id == ID);
            SessionHelpers.carrito.Remove(aux);
            return RedirectToAction("Index");
        }

        public ActionResult Vaciar()
        {
            SessionHelpers.carrito = null;
            return RedirectToAction("Index");
        }
    }
}