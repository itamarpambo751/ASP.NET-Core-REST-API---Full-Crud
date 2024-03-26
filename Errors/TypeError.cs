namespace REST_API___APS.NET_Core.Errors
{
    public class TypeError(int ErrorCode, string Message)
    {
        public int ErrorCode = ErrorCode;
        public string Message = Message;
    }
}
