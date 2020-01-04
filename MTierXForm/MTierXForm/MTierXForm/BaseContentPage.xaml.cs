using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MTierXForm
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            InitializeComponent();
        }
    }
}