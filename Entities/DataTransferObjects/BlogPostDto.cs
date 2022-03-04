using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class BlogPostDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }        

        public string Description { get; set; }         
    }
}
