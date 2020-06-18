using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductList.Models
{
    public class ItemSort : DbContext
    {
        public ItemSort(DbContextOptions<ItemSort> options)
        : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
