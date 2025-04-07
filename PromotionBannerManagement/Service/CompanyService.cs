using PromotionBannerManagement.DTO;
using PromotionBannerManagement.Models;
using PromotionBannerManagement.Repositories;

namespace PromotionBannerManagement.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepo _companyRepo;
        public CompanyService(ICompanyRepo companyRepo) 
        {
            _companyRepo = companyRepo;
        }

        public bool AddCompany(CompanyDTO companyDTO)
        {
            var newCompany = new Company
            {
                Name = companyDTO.Name,
                PhoneNumber = companyDTO.PhoneNumber
            };
            _companyRepo.AddCompany(newCompany);
            return true;
        }

        public bool UpdateCompanyName(int companyId, string newName)
        {
            return _companyRepo.UpdateCompanyName(companyId, newName);
        }
        public bool DeleteCompany(int companyId)
        {
            return _companyRepo.DeleteCompany(companyId);
        }
        public List<Company> GetCompanies()
        {
            return _companyRepo.GetCompanies();
        }

    }
}
