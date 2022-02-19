﻿using System;


namespace Entities.DataTransferObjects
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageSource { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
