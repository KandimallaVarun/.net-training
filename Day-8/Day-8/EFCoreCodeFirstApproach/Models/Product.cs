using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreCodeFirstApproach.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float Price { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}
