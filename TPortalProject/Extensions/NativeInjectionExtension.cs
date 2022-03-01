using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPortalProject.Application.Interfaces;
using TPortalProject.Application.Services;
using TPortalProject.Application.Services.Interfaces;
using TPortalProject.Data.Repositories;
using TPortalProject.Data.Repositories.Interfaces;

namespace TPortalProject.Extensions
{
    public static class NativeInjectionExtension
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IHomeService, HomeService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion
        }
    }
}