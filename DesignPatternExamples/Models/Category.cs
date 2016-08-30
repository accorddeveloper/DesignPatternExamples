using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatternExamples.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}