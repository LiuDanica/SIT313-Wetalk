using WeTalk.Client.Seedwork;
using WeTalk.Client.Seedwork.Controls;
using Xamarin.Forms;

namespace WeTalk.Client.Views
{
    public class HomePage : MvvmableTabbedPage
    {
        public HomePage(ViewModelBase viewModel) : base(viewModel)
        {
            Children.Add(new ChatPage(viewModel));
            Children.Add(new OnlineUsersPage(viewModel));
            Children.Add(new SettingsPage(viewModel));
        }
    }
}
