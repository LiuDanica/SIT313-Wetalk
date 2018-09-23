using WeTalk.Client.iOS.Infrastructure;
using WeTalk.Client.Model.Contracts;
using WeTalk.Client.Model.Entities;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(InvitationSender))]

namespace WeTalk.Client.iOS.Infrastructure
{
    public class InvitationSender : IContactInvitationSender
    {
        public void Send(Contact contact)
        {
            var smsTo = NSUrl.FromString("sms:" + contact.Number);
            UIApplication.SharedApplication.OpenUrl(smsTo);
        }
    }
}
