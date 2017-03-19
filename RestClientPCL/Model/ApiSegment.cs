﻿namespace RestClientPCL.Model
{
    using System.Net.Http;
    using System.Collections.Generic;

    public class ApiSegment
    {
        public string Name { get; set; }

        public HttpMethod Method { get; set; } = HttpMethod.Get;

        public string UrlSegment { get; set; }

        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();

        public Dictionary<string, string> FormUrlEncodedContents { get; set; } = new Dictionary<string, string>();
    }
}