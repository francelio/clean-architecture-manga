namespace Spa.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Spa.ViewModels;

    /// <summary>
    /// The response for Registration.
    /// </summary>
    public sealed class RegisterResponse
    {
        public RegisterResponse(
            Guid customerId,
            string ssn,
            string name,
            List<AccountDetailsModel> accounts)
        {
            CustomerId = customerId;
            SSN = ssn;
            Name = name;
            Accounts = accounts;
        }

        /// <summary>
        /// Gets customer ID.
        /// </summary>
        [Required]
        public Guid CustomerId { get; }

        /// <summary>
        /// Gets sSN.
        /// </summary>
        [Required]
        public string SSN { get; }

        /// <summary>
        /// Gets name.
        /// </summary>
        [Required]
        public string Name { get; }

        /// <summary>
        /// Gets accounts.
        /// </summary>
        [Required]
        public List<AccountDetailsModel> Accounts { get; }
    }
}