using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Models
{
    public class Pedido
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string shippedAddress { get; set; }
        [Required]
        public string telefono { get; set; }
        [Required]
        public string descripcíon { get; set; }
        [Required]
        public double totalPrice { get; set; }
        [Required]
        public Usuario usuario { get; set; }
        [Required]
        public TipoEstado tipoEstado { get; set; }
        [Required]
        public TipoPago tipoPago { get; set; }
    }
}