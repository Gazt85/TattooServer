using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class BlogPostForManipulationDto
    {
        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(50, ErrorMessage = "El título no puede ser mayor a 50 caracteres.")]
        public string Title { get; set; }      

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(2000, ErrorMessage = "La descripción no puede ser mayor a 2000 caracteres.")]
        public string Description { get; set; }

        public bool Pinned { get; set; }
    }
}
