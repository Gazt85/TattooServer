using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class ClientForCreationDto : ClientForManipulationDto
    {          
        public bool IsAdmin { get; set; } 
    }
}
