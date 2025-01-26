using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("GraphicsCards")]
    public class GraphicsCard
    {
        [Key]
        public int GraphicsCardID { get; set; }
        public int BrandID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        public decimal MemoryGB { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }

        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }
    }
}