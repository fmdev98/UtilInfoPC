using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("ConnectionTypes")]
    public class ConnectionType
    {
        [Key]
        public int ConnectionTypeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}