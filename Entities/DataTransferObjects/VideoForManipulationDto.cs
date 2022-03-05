using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public abstract class VideoForManipulationDto
    {

        [Required(ErrorMessage = "El Link es obligatorio")]
        [MaxLength(500, ErrorMessage = "El Link no puede ser mayor a 500 caracteres.")]
        public string Link { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(50, ErrorMessage = "El título no puede ser mayor a 50 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(150, ErrorMessage = "La descripción no puede ser mayor a 150 caracteres.")]
        public string Description { get; set; }
    }
}
