using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdminUI.Areas.AdminModule.AspDotNetCoreConfiguration.Middlewares
{
    public static class AdminApplicationBuilderExtension
    {
        public static void UseAdminStaticFiles(this IApplicationBuilder app)
        {
            var embeddedProvider =
                    new EmbeddedFileProvider(typeof(AdminUI.Areas.AdminModule.Controllers.AdminDemoController)
                    .Assembly, "AdminUI.Resources");


            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = embeddedProvider,
                //RequestPath = new PathString("/AdminResource")
                RequestPath = "/AdminResource"
            });
        }
    }
}
