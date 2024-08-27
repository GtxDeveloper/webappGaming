using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Middlewares
{
    public class CustomMiddleware
    {
        //делегат, который содержит указатель на следующий метод в конвеере запросов
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //метод который выполняет нашу кастомную работу.....
        public async Task InvokeAsync(HttpContext context)
        {
            string method = context.Request.Method;
            switch (method)
            {
                case "GET":
                    {

                        break;
                    }
                case "POST":
                    {

                        break;
                    }
                case "PUT":
                    {

                        break;
                    }
                case "DELETE":
                    {

                        break;
                    }
                default:
                    break;
            }
            //Передаем контекст управления следующему middleware
            await _next.Invoke(context);
        }
    }
}
