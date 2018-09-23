using WeTalk.Server.Application.DataTransferObjects.Messages;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class UserBlacklistRequest : RequestBase
    {
    }
    public class UserBlacklistResponse : ResponseBase
    {
        public UserDto[] Blacklist { get; set; }
    }
}