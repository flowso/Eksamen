using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductList.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Unit{ get; set; }
        public int Stock { get; set; }
        public string Price { get; set; }
        public string Type { get; set; }
    }
}
