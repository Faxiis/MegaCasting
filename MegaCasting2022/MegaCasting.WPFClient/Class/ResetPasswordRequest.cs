using System;
using System.Collections.Generic;

namespace MegaCasting.WPFClient.Class
{
    public partial class ResetPasswordRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Selector { get; set; } = null!;
        public string HashedToken { get; set; } = null!;
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime RequestedAt { get; set; }
        /// <summary>
        /// (DC2Type:datetime_immutable)
        /// </summary>
        public DateTime ExpiresAt { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
