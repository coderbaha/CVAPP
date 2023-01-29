using Helper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        public string savePath;
        public ExceptionMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }
        public async Task Invoke(HttpContext httpContext, IHostingEnvironment hostingEnvironment)
        {
            try
            {
                await _next(httpContext);

            }
            catch (Exception e)
            {
                ExceptionLogHelper.LogFile(httpContext, e, hostingEnvironment);
                throw;
            }
        }
    }
}
