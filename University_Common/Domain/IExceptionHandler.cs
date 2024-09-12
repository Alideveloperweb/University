using Microsoft.AspNetCore.Http;

namespace University_Common.Domain
{
    public interface IExceptionHandler
    {
        Task HandleExceptionAsync(HttpContext context, Exception exception);
    }
}
