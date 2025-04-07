using System.ComponentModel.DataAnnotations;

namespace PromotionBannerManagement.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status => EndDate < DateTime.UtcNow ? "Active" : "Completed";

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
