﻿using GL.Sdk.Http.Batching.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GL.Sdk.Http.Batching.Extensions
{
    public static class HttpBatchingMiddlewareExtension
    {
        public static IServiceCollection AddHttpBatching(this IServiceCollection service, Action<HttpBatchingMiddlewareOptions> options = default)
        {
            options = options ?? (opts => { });
            service.Configure(options);
            return service;
        }

        public static IApplicationBuilder UseHttpBatching(this IApplicationBuilder app)
        {
            return app.UseMiddleware<HttpBatchingMiddleware>();
        }
    }
}
