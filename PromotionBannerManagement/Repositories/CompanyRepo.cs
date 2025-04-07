using PromotionBannerManagement.Models;

namespace PromotionBannerManagement.Repositories
{
    public class CompanyRepo : ICompanyRepo
    {
        private ApplicationDbContext _context;
        public CompanyRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCompany(Company newCompany)
        {
            _context.Companies.Add(newCompany);
            _context.SaveChanges();
        }
        public bool UpdateCompanyName(int companyId, string newName)
        {
            var company = _context.Companies.FirstOrDefault(c => c.CompanyId == companyId);
            if (company == null)
            {
                return false;
            }
            else
            {
                company.Name = newName;
                _context.SaveChanges();
                return true;
            }
        }
        public List<Company> GetCompanies(){
            return _context.Companies.ToList();
        }

        public bool DeleteCompany(int companyId)
        {
            var company = _context.Companies.FirstOrDefault(c => c.CompanyId == companyId);
            if (company == null)
            {
                return false; //or gives an exception
            }
            else
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
