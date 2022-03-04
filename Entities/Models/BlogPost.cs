using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    /// <summary>
    /// Represents the content of the blogpost/article.
    /// </summary>
    public class BlogPost
    {
        [Column("BlogPostId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(250, ErrorMessage = "El título no puede ser mayor a 250 caracteres.")]
        public string Title { get; set; }   

        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(2000, ErrorMessage = "La descripción no puede ser mayor a 2000 caracteres.")]
        public string Description { get; set; }

        /// <summary>
        /// Enables the blog to be pinned on top regardless of the post's date.
        /// </summary>
        public bool Pinned { get; set; }
    }
}
