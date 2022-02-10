using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class User
    {
        [Key]
        [Column("UserId")]
        [Required(ErrorMessage = "Debe ingresar un email")]
        [MaxLength(200, ErrorMessage = "El email no puede ser mayor a 200 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [MaxLength(25, ErrorMessage = "La contraseña no puede ser mayor a 25 caracteres.")]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
