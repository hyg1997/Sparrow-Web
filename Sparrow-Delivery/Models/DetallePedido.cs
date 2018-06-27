using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Models
{
    public class DetallePedido
    {
        [Key]
        public int ID { get; set; }
        public Producto producto { get; set; }
        public Pedido pedido { get; set; }
    }
}