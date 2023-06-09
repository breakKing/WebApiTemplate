using FastEndpoints.Swagger;
using NJsonSchema;

namespace WebApiTemplate.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureDependencyInjection(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddFastEndpoints();

        services.SwaggerDocument(o =>
        {
            o.DocumentSettings = settings =>
            {
                settings.Title = "FastEndpointsTemplate";
                settings.Version = "v1";
                settings.SchemaType = SchemaType.OpenApi3;
            };
        });

        return services;
    }
}