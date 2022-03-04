using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DataTransferObjects
{
    public abstract class BlogItemForManipulationDto
    {
        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(150, ErrorMessage = "El título no puede ser mayor a 150 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "El resumen es obligatorio")]
        [MaxLength(250, ErrorMessage = "El resumen no puede ser mayor a 250 caracteres.")]
        public string Summary { get; set; }

        public bool IsPinned { get; set; }
    }
}
