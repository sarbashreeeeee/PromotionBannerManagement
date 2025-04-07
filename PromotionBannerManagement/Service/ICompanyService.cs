using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Service
{
    public interface ICompanyService
    {
        public bool AddCompany(CompanyDTO newCompany);
        public bool UpdateCompanyName(int companyId, string newName);
        public bool DeleteCompany(int companyId);
        public List<Company> GetCompanies();
    }
}
