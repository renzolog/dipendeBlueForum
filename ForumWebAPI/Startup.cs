using DipendeForum.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DipendeForumMapper;
using DipendeForum.Repositories.Repositories;
using DipendeForumInterfaces.Interfaces;
using DipendeForumService;
using DipendeForumInterfaces.Iservice;

namespace ForumWebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration
                .GetValue<string>("ConnectionStrings:ForumDbConnectionString");

            #region DI rules
            services.AddDbContext<ForumDbContext>(opt => opt.UseSqlServer(connectionString));
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPostService, PostService>();
<<<<<<< HEAD
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<MessageService>();
=======
            services.AddScoped<IMessageService, MessageService>();
>>>>>>> 0f9f6974c814548a0db76773ffbea9842ea66522
            #endregion

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
