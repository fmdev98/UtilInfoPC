using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    // [Table("Storages")]
    public class Storage
    {
        [Key]
        public int StorageID { get; set; }
        public string? Model { get; set; }
        public int BrandID { get; set; }
        public int CapacityGB { get; set; }
        public int StorageTypeID { get; set; }
        public int InterfaceID { get; set; }
        public int ProtocolID { get; set; }
        public int ConnectionTypeID { get; set; }
        public int MemoryTypeID { get; set; }
    }
}