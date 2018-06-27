using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double precio { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public double stock { get; set; }
        [Required]
        public string urlImage { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        [DefaultValue(1)]
        public int estado { get; set; }
        [Required]
        public Categoria categoria { get; set; }
    }
}