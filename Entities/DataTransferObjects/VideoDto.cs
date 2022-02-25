using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class VideoDto
    {
        public Guid Id { get; set; }
        public string Link { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string ImageSource { get; set; }
    }
}
