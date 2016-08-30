using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternExamples.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        public virtual Category Category { get; set; }
    }
}