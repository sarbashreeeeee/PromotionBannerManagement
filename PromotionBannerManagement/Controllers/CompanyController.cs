using Microsoft.AspNetCore.Mvc;
using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;
using PromotionBannerManagement.Service;

namespace PromotionBannerManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("add-company")]
        public IActionResult AddCompany(CompanyDTO companyInfo)
        {
            var isCompanyCreated = _companyService.AddCompany(companyInfo);

            if (isCompanyCreated)
            {
                return Ok("Company created");
            }
            return BadRequest("Unable to create company");
        }

        [HttpGet("get-companies")]
        public List<Company> GetCompanies()
        {
            return _companyService.GetCompanies();
        }

        [HttpPut("update-company-name")]
        public IActionResult UpdateCompanyName(int companyId, string newName)
        {
            var isCompanyTitleUpdated = _companyService.UpdateCompanyName(companyId, newName);
            if (isCompanyTitleUpdated)
            {
                return Ok("Company name updated successfully");
            }
            else
            {
                return BadRequest("Unable to update company name");
            }
        }

        [HttpDelete("delete-company")]
        public IActionResult DeleteCompany(int companyId)
        {
            var isCompanyDeleted = _companyService.DeleteCompany(companyId);
            if (isCompanyDeleted)
            {
                return Ok($"Company {companyId} deleted successfully");
            }
            else
            {
                return BadRequest("Unable to delete company");
            }
        }
    }
}
