using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Common
{

    //для конфигурирования приложения напрямую
    public class StaticHttpContextException
    {
        public static IApplicationBuilder UseStaticCustomHttpContext(IApplicationBuilder app)
        {
            IHttpContextAccessor httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();

            CustomHttpContext.Configure(httpContextAccessor);

            return app;
        }
    }
}
