using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class AppointmentDataDto
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Used for map to the customer's name
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Used to map to the customer's phone - email
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Used to show only the description
        /// </summary>
        public string ShortDescription { get; set; }

        /// <summary>
        /// Description concatenated with tattoo dimensions
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Customer's phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Customer's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Initial Time
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Final Time
        /// </summary>
        public DateTime EndDatetime { get; set; }

        /// <summary>
        /// Specifies if it will take all day.
        /// </summary>
        public Nullable<bool> IsAllDay { get; set; }

        /// <summary>
        /// Path to the photo uploaded by the customer.
        /// </summary>
        public string PhotoSource { get; set; }

        /// <summary>
        /// Current Status of the appointment.
        /// Probable cases are:
        /// 1 - Tentative - default.
        /// 2 - Confirmed - authorized by the admin.
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Indicates if the user has previous tattoos.
        /// </summary>
        public int HasPreviousTattoos { get; set; }

        /// <summary>
        /// Tattoo width
        /// </summary>
        public string TattooWidth { get; set; }

        /// <summary>
        /// Tattoo height
        /// </summary>
        public string TattooHeight { get; set; }
    }
}
