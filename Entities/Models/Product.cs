using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Debe ingeresar el nombre del producto")]
        [MaxLength(50, ErrorMessage = "El nombre no puede ser mayor a 50 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe ingeresar la descripción del producto")]
        [MaxLength(150, ErrorMessage = "La descripción no puede ser mayor a 100 caracteres.")]
        public string Description { get; set; }

        /// <summary>
        /// Used to differentiate between different types of products.
        /// Could be "merchandising", "digital artwork", "paintings".
        /// </summary>
        [Required(ErrorMessage = "Debe ingeresar la categoría del producto")]
        [MaxLength(50, ErrorMessage = "La categoría no puede ser mayor a 50 caracteres.")]
        public string Category { get; set; }

        [MaxLength(500, ErrorMessage = "El nombre de la imagen es demasiado largo.")]
        public string ImageSource { get; set; }

        [Required(ErrorMessage = "Debe ingeresar el precio del producto")]
        public decimal Price { get; set; }
    }
}
