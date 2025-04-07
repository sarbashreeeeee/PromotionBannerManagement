using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;
using PromotionBannerManagement.Repositories;

namespace PromotionBannerManagement.Service
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepo _bannerRepo;
        public BannerService(IBannerRepo bannerRepo)
        {
            _bannerRepo = bannerRepo;
        }
        public bool AddBanner(BannerDTO bannerDTO)
        {
            var newbanner = new Banner
            {
                Title = bannerDTO.Title,
                Description = bannerDTO.Description,
                StartDate = bannerDTO.StartDate,
                EndDate = bannerDTO.EndDate,
                
            };
            _bannerRepo.AddBanner(newbanner);
            return true;
        }

        public bool DeleteBanner(int bannerId)
        {
            var banner = _bannerRepo.GetBanners().FirstOrDefault(b => b.BannerId == bannerId);
            if (banner == null)
            {
                return false; //or gives an exception
            }
            else
            {
                _bannerRepo.DeleteBanner(bannerId);
                return true;
            }
        }

        public List<Banner> GetBanners()
        {
            return _bannerRepo.GetBanners();
        }

        public bool UpdateBannerTitle(int bannerId, string newTitle)
        {
            return _bannerRepo.UpdateBannerTitle(bannerId, newTitle);
        }
    }
}
