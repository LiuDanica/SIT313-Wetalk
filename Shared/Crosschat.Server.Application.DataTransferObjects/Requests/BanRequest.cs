using WeTalk.Server.Application.DataTransferObjects.Enums;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class BanRequest : RequestBase
    {
        public string Reason { get; set; }
        public int TargetUserId { get; set; }
        public bool Ban { get; set; }
    }
    public class BanResponse : ResponseBase
    {
        public BanResponseType Result { get; set; }
    }
}