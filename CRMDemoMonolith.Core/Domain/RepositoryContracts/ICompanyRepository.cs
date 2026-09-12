using CRMDemoMonolith.Core.Domain.Entities;

namespace CRMDemoMonolith.Core.Domain.RepositoryContracts
{
    /// <summary>
    /// Represents data access logic for managing Company entity.
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Adds a new Company object to the data store.
        /// </summary>
        /// <param name="company">Company object to add.</param>
        /// <returns>Returns the Company object after adding it to the data store.</returns>
        Task<Company> AddCompany(Company company);

        /// <summary>
        /// Returns all Companies from the data store.
        /// </summary>
        /// <returns>List of Company objects from the data store.</returns>
        Task<IEnumerable<Company>> GetAllCompanies();

        /// <summary>
        /// Returns an Company object based on the given Company ID. Otherwise, it returns null.
        /// </summary>
        /// <param name="companyId">CompanyId to search.</param>
        /// <returns>Matching Company or null.</returns>
        Task<Company?> GetCompanyByCompanyId(Guid companyId);

        /// <summary>
        /// Updates an Company object based on the given Company ID.
        /// </summary>
        /// <param name="company">Company object to update.</param>
        /// <returns>Returns the updated Company object.</returns>
        Task<Company?> UpdateCompany(Company company);

        /// <summary>
        /// Deletes Company object based on the Company ID.
        /// </summary>
        /// <param name="companyId">Company's Id (GUID) to search.</param>
        /// <returns>Returns true, if the deletion is successful. Otherwise false.</returns>
        Task<bool> DeleteCompanyByCompanyId(Guid companyId);
    }
}
