using ItemStoreProject.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemStoreProject.Models
{
    public class OfferViewModel
    {
        public List<Offer> Offers { get; set; }
        public List<Product> Products { get; set; }
        public string OwnerId { get; set; }
        public string errorMessage { get; set; }
    }
}
