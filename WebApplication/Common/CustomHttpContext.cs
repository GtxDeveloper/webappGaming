using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Common
{

    // Наша кастомная обертка над системным HttpContext
    public static class CustomHttpContext
    {
        //позволит получить доступ к системному HttpContext нашего приложения
        private static IHttpContextAccessor _httpAccessor;

        //часть конфигурирования сисемы нашего приложения
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpAccessor = httpContextAccessor;
        }

        public static HttpContext HttpContext
        {
            get
            {
                return _httpAccessor.HttpContext;
            }
        }
    }
}
