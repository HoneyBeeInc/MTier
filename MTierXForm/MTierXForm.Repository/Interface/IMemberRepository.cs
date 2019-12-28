using MTier.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTierXForm.Repository.Interface
{
    public interface IMemberRepository
    {
        Member GetMember(int memberId);
    }
}
