using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class BlogPostForUpdateDto
    {
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(50, ErrorMessage = "El título no puede ser mayor a 50 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "El resumen es obligatorio")]
        [MaxLength(150, ErrorMessage = "El resumen no puede ser mayor a 150 caracteres.")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(2000, ErrorMessage = "La descripción no puede ser mayor a 2000 caracteres.")]
        public string Description { get; set; }
    }
}
