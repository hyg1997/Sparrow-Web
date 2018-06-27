using Sparrow_Delivery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.ViewModels
{
    public class Item
    {
        public Producto producto { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int cantidad { get; set; }
    }
}