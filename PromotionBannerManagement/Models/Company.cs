using System.ComponentModel.DataAnnotations;

namespace PromotionBannerManagement.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }  
        public ICollection<Banner> Banners { get; set; } = new List<Banner>();
    }
}

