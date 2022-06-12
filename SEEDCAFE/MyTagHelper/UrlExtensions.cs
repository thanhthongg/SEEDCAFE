﻿using Microsoft.AspNetCore.Http;
namespace SEEDCAFE.MyTagHelper
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
        request.QueryString.HasValue
        ? $"{request.Path}{request.QueryString}"
        : request.Path.ToString();
    }
}