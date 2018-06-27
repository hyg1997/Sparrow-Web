using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sparrow_Delivery.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Correo electrónico")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required]
        [DisplayName("Contraseña")]
        [StringLength(
            16,
            ErrorMessage = "Contraseña tiene que tener entre 5 y 16 caracteres",
            MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DisplayName("Confirmar Contraseña")]
        [StringLength(16, ErrorMessage = "Contraseña tiene que tener entre 5 y 16 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("password")]
        [NotMapped]
        public string confirmPassword { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [Required]
        [DisplayName("Apellido")]
        public string apellido { get; set; }

        [Required]
        [StringLength(
            8,
            ErrorMessage = "Ingrese un número de DNI correcto",
            MinimumLength = 8)]
        public string DNI { get; set; }

        [Required]
        public string userAddress { get; set; }
    }
}