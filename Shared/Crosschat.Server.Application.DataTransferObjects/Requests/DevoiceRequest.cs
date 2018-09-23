using WeTalk.Server.Application.DataTransferObjects.Enums;

namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class DevoiceRequest : RequestBase
    {
        public string Reason { get; set; }
        public int TargetUserId { get; set; }
        public bool Devoice { get; set; }
    }

    public class DevoiceResponse : ResponseBase
    {
        public DevoiceResponseType Result { get; set; }
    }
}