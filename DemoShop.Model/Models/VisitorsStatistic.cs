using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoShop.Model.Models
{
    [Table("VisitorsStatistics")]
    public class VisitorsStatistic
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}