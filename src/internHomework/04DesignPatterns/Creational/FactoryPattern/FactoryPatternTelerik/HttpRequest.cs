using System.Collections.Generic;
using System.Linq;

namespace FactoryPattern.FactoryPatternTelerik
{
    public class HttpRequest : IHttpRequest
    {
        private string method;
        private string url;

        private IDictionary<string, string> headers;

        public string Method 
        {
            get
            {
                return method;
            }
            set
            {
                method = value;
            }
        }

        public string Url 
        { 
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

        public IDictionary<string, string> Headers 
        { 
            get
            {
                return headers;
            }
            set
            {
                headers = value;
            }
        }

        public HttpRequest(string method, string url, string[] customHeaders) 
        {
            this.method = method;
            this.url = url;
            headers = new Dictionary<string, string>();

            if (customHeaders != null)
            {
                for (int i = 0; i < customHeaders.Length; i += 2)
                {
                    headers.Add(customHeaders[i], customHeaders[i + 1]);
                }
            }
        }

        public override string ToString()
        {
            var headersToString = headers.Select(x => x.Key + ": " + x.Value).ToList();

            return $"Request:\n{method} to {url}" + "\nHeaders:\n" + string.Join("\n ", headersToString);
        }
    }
}
