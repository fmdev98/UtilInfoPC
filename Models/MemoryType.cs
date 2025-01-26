using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("MemoryTypes")]
    public class MemoryType
    {
        [Key]
        public int MemoryTypeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}