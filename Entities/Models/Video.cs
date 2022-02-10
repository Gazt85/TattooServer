using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Video
    {
        [Column("VideoId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El Link es obligatorio")]
        [MaxLength(500, ErrorMessage = "El Link no puede ser mayor a 500 caracteres.")]
        public string Link { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(50, ErrorMessage = "El título no puede ser mayor a 50 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(150, ErrorMessage = "La descripción no puede ser mayor a 150 caracteres.")]
        public string Description { get; set; }

        public string ImageSource { get; set; }

        public DateTime Date { get; set; }
    }
}
