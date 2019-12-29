using MTierXForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MTierXForm
{
    public partial class MainPage : ContentPage
    {
        public IMemberService _memberService;
        public MainPage()
        {
            InitializeComponent();
            _memberService = DependencyService.Get<IMemberService>();
        }

        private void DemoButton_Clicked(object sender, EventArgs e)
        {
            var member = _memberService.GetMember(1);
            DemoButton.Text = $"Is your name {member.FirstName}?";
        }
    }
}
