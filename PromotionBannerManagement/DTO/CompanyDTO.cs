using System.ComponentModel.DataAnnotations;

namespace PromotionBannerManagement.DTO
{
    public class CompanyDTO
    {
        [Required]  
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 10)]
        public string PhoneNumber { get; set; }
    }
}
