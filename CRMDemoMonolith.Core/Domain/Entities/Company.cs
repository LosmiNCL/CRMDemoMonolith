using CRMDemoMonolith.Core.Enum;
using System.ComponentModel.DataAnnotations;

namespace CRMDemoMonolith.Core.Domain.Entities
{
    /// <summary>
    /// Domain Model for Account
    /// </summary>
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }

        public string? CompanyName { get; set; }

        public string? Phone {  get; set; }

        public string? Email { get; set; }

        public string? Website { get; set; }

        public string? BillingCountry { get; set; }

        public string? BillingCity { get; set; }

        public string? ShippingAddress { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public AccountTypeOptions CompanyType {  get; set; }

    }
}
