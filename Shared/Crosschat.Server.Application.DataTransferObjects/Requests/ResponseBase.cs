namespace WeTalk.Server.Application.DataTransferObjects.Requests
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            RequestResult = true;
        }
        public long Token { get; set; }
        public bool RequestResult { get; set; }

        public CommonErrors Error { get; set; }
    }

    public enum CommonErrors
    {
        Success = 0,
        Maintenance,
        Banned,
    }
}