using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UtilInfoPC.Models
{
    [Table("V_ComputerSimpleDetails")]
    public class ComputersSimpleDetail
    {
        [Key]
        public int ComputerID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Processor { get; set; }
        public int RAM { get; set; }
        public string? Brand { get; set; }
        public string? GraphicCard { get; set; }
        public int? Storage { get; set; }
        public int? ComputerStorage { get; set; }
        public string? ImageUrl { get; set; }
    }
}