using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.Interfaces;
using BL.Services;

namespace BL
{
    public class ServicesConfiguration
    {
        public static void ConfigreService(IServiceCollection services)
        {
            services.AddScoped<IRepositoriesService, RepositoriesService>();
            services.AddScoped<IAuthService, AuthService>();
        }
    }
}
