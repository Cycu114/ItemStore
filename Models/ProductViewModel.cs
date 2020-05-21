using ItemStoreProject.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStoreProject.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }

        public List<Category> Categories{ get; set; }
        public string errorMessage { get; set; }
    }
}
