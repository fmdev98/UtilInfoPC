using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("RAMs")]
    public class RAM
    {
        [Key]
        public int RAMID { get; set; }
        public int CapacityGB { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        public decimal Frequency { get; set; }
    }
}
