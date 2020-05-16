using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace VirtualWhiteboardAPI.Helpers
{
    public class MyAPIException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ContentType { get; set; } = @"text/plain";

        public MyAPIException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public MyAPIException(HttpStatusCode statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }

        public MyAPIException(HttpStatusCode statusCode, Exception inner) : this(statusCode, inner.ToString()) { }

        public MyAPIException(HttpStatusCode statusCode, JObject errorObject) : this(statusCode, errorObject.ToString())
        {
            ContentType = @"application/json";
        }
    }
}
