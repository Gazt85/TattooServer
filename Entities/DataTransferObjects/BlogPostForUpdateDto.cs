﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class BlogPostForUpdateDto : BlogPostForManipulationDto
    {       
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}
