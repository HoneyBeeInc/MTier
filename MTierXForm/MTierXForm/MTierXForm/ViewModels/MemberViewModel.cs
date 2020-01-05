using MTierXForm.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MTierXForm.ViewModels
{
    public class MemberViewModel : BaseViewModel
    {
        private Member _member;
        public Member Member
        {
            get
            {
                return _member;
            }
            set
            {
                _member = value;
                OnPropertyChanged("Member");
            }
        }

        public MemberViewModel()
        {
            LoadData();
        }

        private void LoadData()
        {
            Member = _memberService.GetMember(1);
        }
    }
}
