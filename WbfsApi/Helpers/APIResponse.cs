namespace WbfsApi.Helpers
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public required string ResponseMessage { get; set; }
        public bool? ErrorStatus { get; set; }
        public T? ResponseData { get; set; }

        /*public ApiResponse(int statusCode, string message, bool? error, T? data)
        {
            StatusCode = statusCode;
            ResponseMessage = message;
            ErrorStatus = error;
            ResponseData = data;
        }*/
    }
}
