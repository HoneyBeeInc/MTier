using MTierXForm.Domain.Enum;
using System;

namespace MTierXForm.Domain.Model
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public TierType TierId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
