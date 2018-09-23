using WeTalk.Server.Application.DataTransferObjects.Messages;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class LastMessageRequest : RequestBase { }
    public class LastMessageResponse : ResponseBase
    {
        public string Subject { get; set; }

        public PublicMessageDto[] Messages { get; set; }
    }
}