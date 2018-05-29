﻿using System;

namespace Chap06_04.Core.Model
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Guid CategoryId { get; set; }
        public int InStock { get; set; }

        public virtual Category Category { get; set; }
    }
}