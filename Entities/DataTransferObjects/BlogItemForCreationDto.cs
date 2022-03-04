using System;

namespace Entities.DataTransferObjects
{
    public class BlogItemForCreationDto : BlogItemForManipulationDto
    {
        public DateTime InsertDate { get; set; } = DateTime.Now;
    }
}
