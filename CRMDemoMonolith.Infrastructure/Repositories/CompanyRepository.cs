using CRMDemoMonolith.Core.Domain.Entities;
using CRMDemoMonolith.Core.Domain.RepositoryContracts;
using CRMDemoMonolith.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CRMDemoMonolith.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Company> AddCompany(Company company)
        {
            _db.Companies.Add(company);
            await _db.SaveChangesAsync();

            return company;
        }

        public async Task<IEnumerable<Company>> GetAllCompanies()
        {
            List<Company> companies = await _db.Companies
                .OrderBy(temp => temp.CompanyName).ToListAsync();

            return companies;
        }

        public async Task<Company?> GetCompanyByCompanyId(Guid companyId)
        {
            return await _db.Companies
                .FirstOrDefaultAsync(temp => temp.CompanyId == companyId);
        }

        public async Task<Company?> UpdateCompany(Company company)
        {
            Company? matchingCompany = await _db.Companies
                .FirstOrDefaultAsync(temp => temp.CompanyId == company.CompanyId);

            if (matchingCompany == null) return null;

            matchingCompany.CompanyName = company.CompanyName;
            matchingCompany.Phone = company.Phone;
            matchingCompany.Email = company.Email;
            matchingCompany.Website = company.Website;
            matchingCompany.BillingCountry = company.BillingCountry;
            matchingCompany.BillingCity = company.BillingCity;
            matchingCompany.ShippingAddress = company.ShippingAddress;
            matchingCompany.Description = company.Description;
            matchingCompany.CompanyType = company.CompanyType;

            await _db.SaveChangesAsync();

            return matchingCompany;
        }

        public async Task<bool> DeleteCompanyByCompanyId(Guid companyId)
        {
            int rowsDeleted = await _db.Companies
                .Where(temp => temp.CompanyId == companyId).ExecuteDeleteAsync();

            return rowsDeleted > 0;
        }
    }
}
