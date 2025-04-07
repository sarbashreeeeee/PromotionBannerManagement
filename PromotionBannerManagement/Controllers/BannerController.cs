using Microsoft.AspNetCore.Mvc;
using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;
using PromotionBannerManagement.Service;

namespace PromotionBannerManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BannerController
    {
        private IBannerService _bannerService;
        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        [HttpPost("add-banner")]
        public IActionResult AddBanner(BannerDTO bannerInfo)
        {
            var isBannerCreated = _bannerService.AddBanner(bannerInfo);

            if (isBannerCreated)
            {
                return Ok("Banner created");
            }
            return BadRequest("Unable to create banner");
        }

        [HttpGet("get-banners")]
        public List<Banner> GetBanners()
        {
            var bannerList = _bannerService.GetBanners();
            return bannerList;
        }

        [HttpPut("update-banner-title")]
        public IActionResult UpdateBannerTitle(int bannerId, string newTitle)
        {
            var isBannerTitleUpdated = _bannerService.UpdateBannerTitle(bannerId, newTitle);
            if (isBannerTitleUpdated)
            {
                return Ok("Banner title updated successfully");
            }
            else
            {
                return BadRequest("Unable to update banner title");
            }
        }

        [HttpDelete("delete-banner")]
        public IActionResult DeleteBanner(int bannerId)
        {
            var isBannerDeleted = _bannerService.DeleteBanner(bannerId);
            if (isBannerDeleted)
            {
                return Ok($"Banner {bannerId} deleted successfully");
            }
            else
            {
                return BadRequest("Unable to delete banner");
            }
        }
    }
}
