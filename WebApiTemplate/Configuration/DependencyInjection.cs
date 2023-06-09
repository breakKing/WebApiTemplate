using System.Text.Json;
using System.Text.Json.Serialization;
using FastEndpoints.Swagger;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
                settings.Title = "WebApiTemplate";
                settings.Version = "v1";
                settings.SchemaType = SchemaType.OpenApi3;
                settings.MarkNonNullablePropsAsRequired();
                settings.AllowNullableBodyParameters = true;
                settings.GenerateEnumMappingDescription = true;
                settings.SerializerSettings = new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
            };

            o.SerializerSettings = s =>
            {
                s.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                s.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                s.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            };

            o.ShortSchemaNames = true;
        });

        return services;
    }
}