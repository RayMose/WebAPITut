using System.Web.Http;
using WebActivatorEx;
using WebAPITut;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebAPITut
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                c.SingleApiVersion("v1", "First WEB API DEMO");
                    c.IncludeXmlComments(string.Format(@"{0}\bin\WebAPITut.XML",
                                       System.AppDomain.CurrentDomain.BaseDirectory));
                })
                .EnableSwaggerUi();
        }
    }
}