using MTierXForm.Domain.Model;
using MTierXForm.Repository.Interface;
using MTierXForm.Service.Interface;
using Xamarin.Forms;

namespace MTierXForm.Service
{
    public class MemberService : IMemberService
    {
        private IMemberRepository _memberRepository;

        public MemberService()
        {
            _memberRepository = DependencyService.Get<IMemberRepository>();
        }

        public Member GetMember(int memberId)
        {
            return _memberRepository.GetMember(memberId);
        }
    }
}
