using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class BlogItemForUpdateDto : BlogItemForManipulationDto
    {
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
