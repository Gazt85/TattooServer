using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Client : User
    {              

        [Required(ErrorMessage = "Debe ingeresar el nombre")]
        [MaxLength(100, ErrorMessage = "El nombre no puede ser mayor a 100 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        [MaxLength(100, ErrorMessage = "El apellido no puede ser mayor a 100 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de télefono")]
        [MaxLength(100, ErrorMessage = "El número de telefono no puede ser mayor a 100 caracteres.")]
        public string Phone { get; set; }
    }
}
