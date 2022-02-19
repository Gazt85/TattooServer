using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class BlogItemDto
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
