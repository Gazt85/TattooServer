using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class AppointmentData
    {
        [Column("AppointmenId")]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        /// <summary>
        /// Current Status of the appointment.
        /// Probable cases are:
        /// 0 - Tentative - default.
        /// 1 - Confirmed - authorized by the admin.
        /// </summary>
        [ForeignKey(nameof(Status))]
        public int StatusId { get; set; }

        [Required(ErrorMessage = "Debe ingeresar el nombre")]
        [MaxLength(100, ErrorMessage = "El nombre no puede ser mayor a 100 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        [MaxLength(100, ErrorMessage = "El apellido no puede ser mayor a 100 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de télefono")]
        [MaxLength(100, ErrorMessage = "El número de telefono no puede ser mayor a 100 caracteres.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Debe ingressar una descripción")]
        [MaxLength(500, ErrorMessage = "La descripción no puede ser mayor a 500 caracteres.")]
        public string TattooDescription { get; set; }

        public bool HasPreviousTattoos { get; set; }

        [Required(ErrorMessage = "Debe ingresar el largo del tatuaje")]

        public double TattooHeight { get; set; }

        [Required(ErrorMessage = "Debe ingresar el ancho del mesaje")]
        public double TattooWidth { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha del tatuaje")]
        public DateTime StartDateTime { get; set; }

        public DateTime EndDatetime { get; set; }

        public string Photo { get; set; }

        public User User { get; set; }
        public int Status { get; set; }


    }
}
