using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    
    // [Table("Computers")]
    public class Computer
    {
        [Key]
        public int ComputerID { get; set; }
        public int BrandID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int ProcessorID { get; set; }
        public int RAMID { get; set; }
        public int? StorageID { get; set; }
        public int? StorageGB { get; set; }
        public int GraphicsCardID { get; set; }
        public string? ImageUrl { get; set; }
    }

}