using WeTalk.Client.ViewModels;
using WeTalk.Client.Views;
using Xamarin.Forms;

namespace WeTalk.Client
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new SplashscreenPage());
        }
    }
}
