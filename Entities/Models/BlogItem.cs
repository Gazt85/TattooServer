using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class BlogItem
    {
        [Column("BlogId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio")]
        [MaxLength(150, ErrorMessage = "El título no puede ser mayor a 150 caracteres.")]
        public string Title { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "El resumen es obligatorio")]
        [MaxLength(250, ErrorMessage = "El resumen no puede ser mayor a 250 caracteres.")]
        public string Summary { get; set; }

        [ForeignKey(nameof(BlogPost))]
        public Guid BlogPostId { get; set; }

        public BlogPost BlogPost { get; set; }
    }
}
