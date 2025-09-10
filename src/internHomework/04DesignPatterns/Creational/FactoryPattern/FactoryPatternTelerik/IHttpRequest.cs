using System.Collections.Generic;

namespace FactoryPattern.FactoryPatternTelerik
{
    public interface IHttpRequest
    {
        string Method { get; set; }

        string Url { get; set; }

        IDictionary<string, string> Headers { get; set; }
    }
}
