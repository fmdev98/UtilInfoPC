using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    public class Brand
    {
        [Key]
        public int BrandID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
