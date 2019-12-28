using MTier.Domain.Enum;
using System;

namespace MTier.Domain
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public TierType Tier { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
