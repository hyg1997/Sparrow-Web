using Sparrow_Delivery.Models;
using Sparrow_Delivery.ViewModels;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sparrow_Delivery.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index(int? ID)
        {
            ViewProduct vm = new ViewProduct();
            vm.cargarData();
            using (var db = new SparrowModel())
            {
                if (!ID.HasValue)
                {
                    vm.productos = db.Producto.ToList();
                }
                else
                {
                    vm.productos = db.Producto.
                        Include(x => x.categoria).
                        Where(x => x.categoria.ID == ID).ToList();
                }
            }
            return View(vm);
        }
    }
}