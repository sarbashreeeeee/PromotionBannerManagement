using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Repositories
{
    public interface IBannerRepo
    {
        public void AddBanner(Banner newBanner);
        public bool UpdateBannerTitle(int bannerId, string newTitle);
        public bool DeleteBanner(int BannerId);
        public List<Banner> GetBanners();
    }
}
