using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseShemaManager.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } 

        [MaxLength(2000)]
        public string Description { get; set; }

        public string File { get; set; } //TODO: Change to unique in model builder

        [Required]
        public int PurchasePrice { get; set; }

        [Required]
        public int SalePrice { get; set; }

        [Required]
        public Category Category { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }
    }
}
