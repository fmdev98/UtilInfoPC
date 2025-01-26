using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("StorageTypes")]
    public class StorageType
    {
        [Key]
        public int StorageTypeID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}