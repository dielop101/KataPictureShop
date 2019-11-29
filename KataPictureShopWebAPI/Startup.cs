using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PictureShopDataAccess;
using PictureShopDataAccessContracts;
using PictureShopService.Contracts.Interface;
using PictureShopService.Impl;
using Swashbuckle.AspNetCore.Swagger;

namespace KataPictureShopWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IPictureInfoAccess, PictureInfoAccess>();
            services.AddSingleton<IUserInfoAccess, UserInfoAccess>();
            services.AddSingleton<IUserInfoService, UserInfoService>();
            services.AddSingleton<IPictureInfoService, PictureInfoService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "KataPictureShop", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "KataPictureShop V1");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
