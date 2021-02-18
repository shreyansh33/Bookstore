using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _20090534.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method  called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // create a new middleware we can use app and to create a custom middle ware lets use use method

            //  n no of middleware can be inserted

            app.UseStaticFiles();  
            app.UseRouting(); // this is also a middleware // if we comment this line we get error  // before using endpoint we must use routing in the application 
            

            app.UseEndpoints(endpoints => // this is also a middleware 
            {

                /*endpoints.Map("/", async context =>
                {
                    
                    
                        await context.Response.WriteAsync("Hello from dev");
                    
             
                });*/
                endpoints.MapDefaultControllerRoute(); // this gets the message from index method of gome controller
            });
           
        }

    }
}
