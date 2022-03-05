using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class VideoForUpdateDto : VideoForManipulationDto
    {
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;      
    }
}
