using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Product_Management.Models.DomainModels
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string ProductDesc { get; set; }

        [Required]
        public int ProductPrice { get; set; }

        public DateTime ProductCreatedAt { get; set; } = DateTime.Now;  
    }
}