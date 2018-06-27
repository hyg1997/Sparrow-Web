using Sparrow_Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.ViewModels
{
    public class ViewProduct
    {
        public List<Producto> productos { get; set; }
        public List<Categoria> categorias { get; set; }
        public void cargarData()
        {
            productos = new List<Producto>();
            categorias = new List<Categoria>();
            using (var db = new SparrowModel())
            {
                categorias = db.Categoria.ToList();
            }
        }
    }
}