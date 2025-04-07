using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Repositories
{
    public class BannerRepo : IBannerRepo
    {
        private ApplicationDbContext _context;
        public BannerRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBanner(Banner newBanner)
        {
            _context.Banners.Add(newBanner);
            _context.SaveChanges();
        }

        public bool DeleteBanner(int bannerId)
        {
            var banner = _context.Banners.FirstOrDefault(b => b.BannerId ==bannerId);
            if (banner == null)
            {
                return false; //or gives an exception
            }
            else
            {
                _context.Banners.Remove(banner);
                _context.SaveChanges();
                return true;
            }
            
        }
        public bool UpdateBannerTitle(int bannerId, string newTitle)
        {
            var banner = _context.Banners.FirstOrDefault(b => b.BannerId == bannerId);
            if (banner == null)
            {
                return false;
            }
            else
            {
                banner.Title = newTitle;
                _context.SaveChanges();
                return true;
            }

            //copy-paste for other attributes if need to update 

        }
        public List<Banner> GetBanners ()
        {
            return _context.Banners.ToList();
        }
    }
}
