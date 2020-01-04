using MTierXForm.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MTierXForm
{
    public partial class MainPage : BaseContentPage
    {
        public IMemberService _memberService;
        public MainPage()
        {
            InitializeComponent();
            _memberService = DependencyService.Get<IMemberService>();
        }

        private async void EnterButton_Clicked(object sender, EventArgs e)
        {
            //navigate to tier member info page
            await Navigation.PushAsync(new MemberInfo());
        }
    }
}
