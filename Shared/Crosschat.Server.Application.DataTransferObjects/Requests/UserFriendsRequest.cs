using WeTalk.Server.Application.DataTransferObjects.Messages;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class UserFriendsRequest : RequestBase
    {
    }
    public class UserFriendsResponse : ResponseBase
    {
        public UserDto[] Friends { get; set; }
    }
}