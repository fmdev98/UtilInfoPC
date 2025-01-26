using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("Protocols")]
    public class Protocol
    {
        [Key]
        public int ProtocolID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}