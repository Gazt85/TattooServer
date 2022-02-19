using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class ProductForCreationDto
    {
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [MaxLength(30, ErrorMessage = "El nombre no puede ser mayor a 30 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(80, ErrorMessage = "La descripción no puede ser mayor a 80 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Debe ingeresar la categoría del producto")]
        [MaxLength(50, ErrorMessage = "La categoría no puede ser mayor a 50 caracteres.")]
        public string Category { get; set; }

        [MaxLength(500, ErrorMessage = "El nombre de la imagen es demasiado largo.")]
        public string ImageSource { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public decimal Price { get; set; }
    }
}
