using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Service
{
    public interface IBannerService
    {
        public bool AddBanner(BannerDTO bannerDTO);
        public bool UpdateBannerTitle(int bannerId, string newTitle);
        public bool DeleteBanner(int bannerId);
        public List<Banner> GetBanners();
    }
}
