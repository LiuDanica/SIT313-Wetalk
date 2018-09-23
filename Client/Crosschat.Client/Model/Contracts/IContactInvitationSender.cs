using WeTalk.Client.Model.Entities;

namespace WeTalk.Client.Model.Contracts
{
    public interface IContactInvitationSender
    {
        void Send(Contact contact);
    }
}
