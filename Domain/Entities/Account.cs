using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Account
    {
        public Guid Id { get; set; }
        public int Empid { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleType { get; set; }

        public virtual Employee Emp { get; set; } = null!;
    }
}
