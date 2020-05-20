using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemStoreProject.Persistence.Entities
{
    public class Offer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [ForeignKey("Product")] public string ProductId { get; set; }

        [ForeignKey("Owner")] public string OwnerId { get; set; }

        public uint Quantity { get; set; }
        public string Quality { get; set; }
        public decimal Price { get; set; }

        //VALIDTATION
        public Product Product { get; set; }
        public User Owner { get; set; }
    }
}