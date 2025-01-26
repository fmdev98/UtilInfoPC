using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("Processors")]
    public class Processor
    {
        [Key]
        public int ProcessorID { get; set; }
        public int BrandID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Model { get; set; }
        public decimal Frequency { get; set; }
        public int Cores { get; set; }

        [ForeignKey("BrandID")]
        public Brand Brand { get; set; }
    }
}
