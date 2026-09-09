using CRMDemoMonolith.Core.Domain.Entities;

namespace CRMDemoMonolith.Core.Domain.RepositoryContracts
{
    /// <summary>
    /// Represents data access logic for managing Account entity.
    /// </summary>
    public interface IAccountRepository
    {
        /// <summary>
        /// Adds a new Account object to the data store.
        /// </summary>
        /// <param name="account">Account object to add.</param>
        /// <returns>Returns the Account object after adding it to the data store.</returns>
        Task<Account> AddAccount(Account account);

        /// <summary>
        /// Returns all Accounts from the data store.
        /// </summary>
        /// <returns>List of Account objects from the data store.</returns>
        Task<IEnumerable<Account>> GetAllAccounts();

        /// <summary>
        /// Returns an Account object based on the given Account ID. Otherwise, it returns null.
        /// </summary>
        /// <param name="accountId">AccountId to search.</param>
        /// <returns>Matching Account or null.</returns>
        Task<Account?> GetAccountByAccountId(Guid accountId);

        /// <summary>
        /// Updates an Account object based on the given Account ID.
        /// </summary>
        /// <param name="account">Account object to update.</param>
        /// <returns>Returns the updated Account object.</returns>
        Task<Account> UpdateAccount(Account account);

        /// <summary>
        /// Deletes Account object based on the Account ID.
        /// </summary>
        /// <param name="accountId">Account's Id (GUID) to search.</param>
        /// <returns>Returns true, if the deletion is successful. Otherwise false.</returns>
        Task<bool> DeleteAccountByAccountId(Guid accountId);
    }
}
