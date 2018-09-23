using WeTalk.Server.Application.DataTransferObjects.Messages;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class UsersSearchRequest : RequestBase
    {
        public string QueryString { get; set; }
    }
    public class UsersSearchResponse : ResponseBase
    {
        public UserDto[] Result { get; set; }
    }
}
