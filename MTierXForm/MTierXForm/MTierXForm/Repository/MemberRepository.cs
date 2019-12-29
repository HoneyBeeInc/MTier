using MTierXForm.Domain.Model;
using MTierXForm.Repository.Interface;
using System;

namespace MTierXForm.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member GetMember(int memberId)
        {
            return new Member()
            {
                MemberId = memberId,
                FirstName = "Miguel",
                LastName = "Jordan",
                DateOfBirth = new DateTime(1980, 11, 20)
            };
        }
    }
}
