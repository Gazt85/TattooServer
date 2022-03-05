
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class BlogPostForCreationDto : BlogPostForManipulationDto
    {       
        public DateTime InsertDate { get; set; } = DateTime.Now;
    }
}
