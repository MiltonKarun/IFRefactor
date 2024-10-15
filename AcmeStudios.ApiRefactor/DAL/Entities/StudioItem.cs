using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace AcmeStudios.ApiRefactor.DAL.Entities
{
    public class StudioItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudioItemId { get; set; }
        public DateTime Acquired { get; set; }
        public DateTime? Sold { get; set; } = null;
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string SerialNumber { get; set; }
        public decimal Price { get; set; }
        public decimal? SoldFor { get; set; }
        public bool Eurorack { get; set; }
        [Required]
        public int StudioItemTypeId { get; set; }
        public StudioItemType StudioItemType { get; set; }
    }
}
