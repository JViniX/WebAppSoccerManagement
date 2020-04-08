﻿
using Microsoft.AspNetCore.Http;

namespace Julio_C_301016383.Infrastructure
{
    public static class UrlExtensions
    {

        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
    }
}
