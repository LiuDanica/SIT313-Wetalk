using WeTalk.Server.Application.DataTransferObjects.Messages;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class GetOnlineUsersRequest : RequestBase { }
    public class GetOnlineUsersResponse : ResponseBase
    {
        public UserDto[] Users { get; set; }
    }
}