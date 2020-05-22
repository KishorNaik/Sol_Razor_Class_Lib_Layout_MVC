using AdminUI.Areas.AdminModule.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUI.Areas.AdminModule.AspDotNetCoreConfiguration.Services
{
    public static class AdminServiceExtension
    {
        public static void AddAdminService(this IServiceCollection services)
        {
            services.AddTransient<IAdminRepository, AdminRepository>();
        }
    }
}
