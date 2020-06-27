﻿﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6_Dodatkowe.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Request.EnableBuffering();
            if (context.Request != null)
            {
                string body = "";

                using (var reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, true)){
                      body = await reader.ReadToEndAsync();
                      context.Request.Body.Position = 0;
                }
                
                List<String> log = new List<String>();
                log.Add("Path:" +context.Request.Path);
                log.Add("Method:" + context.Request.Method);
                log.Add("QueryString:" + context.Request.QueryString);
                log.Add("Body:" +body);

                await File.AppendAllLinesAsync("Log.txt ", log, Encoding.UTF8);
            }

            await _next(context);
        }
    }
}
