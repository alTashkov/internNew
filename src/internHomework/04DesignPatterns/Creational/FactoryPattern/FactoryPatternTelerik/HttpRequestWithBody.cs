namespace FactoryPattern.FactoryPatternTelerik
{
    public class HttpRequestWithBody : HttpRequest, IHttpRequestWithBody
    {
        private string body;

        private string mimeType;

        public string Body 
        {
            get
            {
                return body;
            }
            set
            {
                Body = value;
            }
        }
        public string MimeType 
        {
            get
            {
                return mimeType;
            }
            set
            {
                mimeType = value;
            }
        }

        public HttpRequestWithBody(string method, string url, string[] customHeaders,string body, string mimeType) 
        : base(method,url,customHeaders)
        {
            this.body = body;
            this.mimeType = mimeType;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Content-type:\n" + mimeType + "\nBODY:\n" + body;
        }
    }
}
