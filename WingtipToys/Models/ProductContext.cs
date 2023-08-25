using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductContext: DbContext
    {
        // WingtipToys: la name cua ConnectionString
        public ProductContext() : base("name=WingtipToys") { }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}