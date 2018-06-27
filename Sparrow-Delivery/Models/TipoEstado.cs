using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Models
{
    public class TipoEstado
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string nombre { get; set; }
    }
}