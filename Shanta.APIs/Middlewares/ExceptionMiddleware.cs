using Shanta.APIs.Errors;
using System.Net;
using System.Text.Json;

namespace Shanta.APIs.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        private readonly IWebHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IWebHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, ex.Message);
                // content type
                context.Response.ContentType = "application/json";
                // status code
                context.Response.StatusCode = (int) HttpStatusCode.InternalServerError;


                var response = _env.IsDevelopment() ? 
                                                new APIExceptionResponse((int) HttpStatusCode.InternalServerError, ex.Message, ex.StackTrace.ToString())
                                                :
                                                new APIExceptionResponse((int) HttpStatusCode.InternalServerError);

                var options = new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                var json = JsonSerializer.Serialize(response, options);

                await context.Response.WriteAsync(json);
            }
        }
    }
}
