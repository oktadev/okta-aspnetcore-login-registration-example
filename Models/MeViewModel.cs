using System;
using System.Collections.Generic;

namespace OktaAspNetCoreMvc.Models
{
    public class MeViewModel
    {
        public string Username { get; set; }
        public dynamic Profile { get; set; }
        public DateTimeOffset? PasswordChanged { get; set; }
        public DateTimeOffset? LastLogin { get; set; }
        public string Status { get; set; }
    }
}
