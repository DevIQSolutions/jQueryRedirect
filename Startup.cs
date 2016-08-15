using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.StaticFiles;

namespace ConsoleApplication
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseDefaultFiles();

            // app.Run(context =>
            // {
            //     context.Response.ContentType="text/html";
            //     return context.Response.WriteAsync("Demo List:<ul><li><a href='demo1.html'>Demo 1</a></li></ul>");
            // });
        }
    }
}
