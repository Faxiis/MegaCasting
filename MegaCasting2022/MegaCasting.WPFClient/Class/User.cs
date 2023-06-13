using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class User
    {
        public User()
        {
            ResetPasswordRequests = new HashSet<ResetPasswordRequest>();
            IdentifierUsers = new HashSet<Offer>();
        }

        public int Id { get; set; }
        public string Email { get; set; } = null!;
        /// <summary>
        /// (DC2Type:json)
        /// </summary>
        public string Roles { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsVerified { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string AddressZipCode { get; set; } = null!;
        public int? ProfesionalLevel { get; set; }
        public string? ImageName { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        public virtual ICollection<ResetPasswordRequest> ResetPasswordRequests { get; set; }

        public virtual ICollection<Offer> IdentifierUsers { get; set; }
    }
}
