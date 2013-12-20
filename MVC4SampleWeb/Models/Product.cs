using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC4SampleWeb.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public double Cost { get; set; }
    }
}