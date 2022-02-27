using Microsoft.Extensions.DependencyInjection;
using System;
using TPortalProject.Application.Interfaces;
using TPortalProject.Application.Services;

namespace TPortalProject.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();

        }

    }
}
