using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using com.Acutrack.Fulfillment;
using com.Acutrack.Fulfillment.WebAPI;
using AcutrackFulfillment.Core.Interfaces;
using AcutrackFulfillment.Infrastructure.Data;
using AcutrackFulfillment.Infrastructure.Cache;
using AutoMapper;
using FluentValidation.AspNetCore;
using com.Acutrack.Fulfillment.WebAPI.Validators;
using FluentValidation;
using com.Acutrack.Fulfillment.WebAPI.Orders;

namespace AcutrackFulfillmentRWS
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddApplicationInsightsTelemetry(Configuration);
            services.AddDbContext<AppDbContext>(c =>
           //c.UseInMemoryDatabase("TestDatabase")
           c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
           
           );
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            }
            );
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<OrderCreateDtoValidator>());
            //services.AddSingleton<IValidator<OrderItemCreateDto>, OrderCreateDtoValidator>();
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (context) =>
                {
                    var errors = context.ModelState.Values.SelectMany(x => x.Errors.Select(p => p.ErrorMessage)).ToList();
                    var result = new
                    {
                        Code = "00009",
                        Message = "Validation errors",
                        Errors = errors
                    };
                    return new BadRequestObjectResult(result);
                };
            });
            services.AddIdentityServer()
              .AddDeveloperSigningCredential()
              .AddInMemoryIdentityResources(Config.IdentityResources)
              .AddInMemoryClients(Config.Clients)
              .AddInMemoryApiResources(Config.Apis)
              .AddTestUsers(TestUsers.Users);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "My API",
                    Description = "My First ASP.NET Core Web API",
                    TermsOfService = "None",
                    //Contact = new Contact() { Name = "Acutrack Dotnet", Email = "contact@acutrack.com", Url = "www.acutrack.com" }
                });
            });

            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped(typeof(EfRepository<>));
            //change it to false for remove cache
            bool useCaching = true;
            if (useCaching)
            {
                services.AddSingleton<IMyCache, MyMemoryCache>();
                services.AddScoped(typeof(IAsyncRepository<>), typeof(CachedRepository<>));
            }
            else
            {
                services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));               
            }
            services.AddScoped<IOrderSearchService, SqlOrderSearchService>();
            services.AddLocalApiAuthentication();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            //Starts here
            app.UseIdentityServer();
            app.UseMvc();
            app.UseSwagger();                    
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "WideWorldImporters API V1");
            });
            //ends here
         

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
