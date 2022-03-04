using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class BlogItemDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Summary { get; set; }

        public bool IsPinned { get; set; }

        public DateTime InsertDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
