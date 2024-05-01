namespace Easy.Services.Services.API
{
    public class HttpStatusCodeResponseErrors : Exception
    {

        public HttpStatusCodeResponseErrors() { }

        public HttpStatusCodeResponseErrors(string message) : base(message) { }

        public HttpStatusCodeResponseErrors(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
