using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvcApp2312144.Models.Entites
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // 1. Name Validations
        [Required(ErrorMessage = "Name cannot be empty")] // Prevents Null/Empty
        [StringLength(50)] // Limits text to 50 characters
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 1000000)]
        public decimal Price { get; set; }
    }
}