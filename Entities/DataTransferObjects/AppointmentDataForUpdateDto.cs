using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AppointmentDataForUpdateDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingeresar el nombre")]
        [MaxLength(100, ErrorMessage = "El nombre no puede ser mayor a 100 caracteres.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido")]
        [MaxLength(100, ErrorMessage = "El apellido no puede ser mayor a 100 caracteres.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de télefono")]
        [MaxLength(100, ErrorMessage = "El número de telefono no puede ser mayor a 100 caracteres.")]
        public string Phone { get; set; }

        [MaxLength(200, ErrorMessage = "El email no puede ser mayor a 200 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingressar una descripción")]
        [MaxLength(500, ErrorMessage = "La descripción no puede ser mayor a 500 caracteres.")]
        public string TattooDescription { get; set; }

        public int HasPreviousTattoos { get; set; }

        [Required(ErrorMessage = "Debe ingresar el largo del tatuaje")]

        public double TattooHeight { get; set; }

        [Required(ErrorMessage = "Debe ingresar el ancho del mesaje")]
        public double TattooWidth { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha del tatuaje")]
        public DateTime DateTime { get; set; }

        public string Photo { get; set; }

        /// <summary>
        /// Current Status of the appointment.
        /// Probable cases are:
        /// 1 - Tentative - default.
        /// 2 - Confirmed - authorized by the admin.
        /// </summary>
        public int StatusId { get; set; }
    }
}
