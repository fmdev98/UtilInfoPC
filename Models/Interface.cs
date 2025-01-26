using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("Interfaces")]
    public class Interface
    {
        [Key]
        public int InterfaceID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}