﻿using ItemStoreProject.Validation;
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
        [Required(ErrorMessage ="Quantity must be positive number")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public uint ?Quantity { get; set; }
        [Required]
        [Quality(ErrorMessage ="Only Excelent, Good, Poor, Bad qualities are accepted")]
        public string Quality { get; set; }
        [Required(ErrorMessage = "Price must be positive number")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public decimal ?Price { get; set; }

        public Product Product { get; set; }
        public User Owner { get; set; }
    }
}