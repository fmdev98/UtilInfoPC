using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    [Table("V_ComputerExtendDetails")]
    public class ComputerExtendDetail
    {
        [Key]
        public int ComputerID { get; set; }
        public string? ComputerModel { get; set; }
        public int? ComputerCapacityGB { get; set; }
        public decimal Price { get; set; }
        public string? ProcessorModel { get; set; }
        public decimal ProcessorFrequency { get; set; }
        public int ProcessorCores { get; set; }
        public int RAMCapacity { get; set; }
        public string? RAMType { get; set; }
        public int StorageCapacity { get; set; }
        public string? StorageType { get; set; }
        public string? StorageInterface { get; set; }
        public string? StorageProtocol { get; set; }
        public string? StorageConnectionType { get; set; }
        public string? StorageMemoryType { get; set; }
        public string? Brand { get; set; }
        public string? GraphicsCardModel { get; set; }
        public int? GraphicsCardMemory { get; set; }
        public string? GraphicsCardType { get; set; }
        public string? ImageUrl { get; set; }
    }
}