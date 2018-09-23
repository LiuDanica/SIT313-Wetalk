using Android.Content;
using Android.Telephony;
using WeTalk.Client.Droid.Infrastructure;
using WeTalk.Client.Model.Contracts;
using WeTalk.Client.Model.Entities;
using Xamarin.Forms;

[assembly: Dependency(typeof(InvitationSender))]

namespace WeTalk.Client.Droid.Infrastructure
{
    public class InvitationSender : IContactInvitationSender
    {
        public void Send(Contact contact)
        {
            SmsManager.Default.SendTextMessage(contact.Number, null, "Check this out: https://github.com/EgorBo/CrossChat-Xamarin.Forms", null, null);
        }
    }
}
