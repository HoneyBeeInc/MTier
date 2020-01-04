using MTierXForm.Repository;
using MTierXForm.Service;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MTierXForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DIRegistration();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void DIRegistration()
        {
            DependencyService.Register<MemberService>();
            DependencyService.Register<MemberRepository>();
        }
    }
}
