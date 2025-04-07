using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Repositories
{
    public interface ICompanyRepo
    {
        public void AddCompany(Company newCompany);
        public bool UpdateCompanyName(int companyId, string newName);
        public bool DeleteCompany(int companyId);
        public List<Company> GetCompanies();
    }
}
