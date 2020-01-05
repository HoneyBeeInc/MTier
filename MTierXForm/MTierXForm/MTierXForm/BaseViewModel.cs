using MTierXForm.Service.Interface;
using System.ComponentModel;
//using System.Threading.Tasks;
using Xamarin.Forms;

namespace MTierXForm
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IMemberService _memberService;
        public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel()
        {
            _memberService = DependencyService.Get<IMemberService>();
        }
        //public async virtual Task LoadData()
        //{

        //}

        protected void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
