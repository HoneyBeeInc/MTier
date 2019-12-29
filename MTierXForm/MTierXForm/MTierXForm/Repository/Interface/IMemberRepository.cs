using MTierXForm.Domain.Model;

namespace MTierXForm.Repository.Interface
{
    public interface IMemberRepository
    {
        Member GetMember(int memberId);
    }
}
