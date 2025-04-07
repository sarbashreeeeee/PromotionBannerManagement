using System.ComponentModel.DataAnnotations;

namespace PromotionBannerManagement.DTO
{
    public class BannerDTO
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        //[Required]
        //public string Status { get; set; } = "Active"; // Default value
    }
}
