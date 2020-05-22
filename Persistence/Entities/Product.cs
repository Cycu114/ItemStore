using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemStoreProject.Persistence.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [ForeignKey("Category")] public string CategoryId { get; set; }
        [Required(ErrorMessage = "Please put the item name")]
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public Category Category { get; set; }
        [NotMappedAttribute]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}