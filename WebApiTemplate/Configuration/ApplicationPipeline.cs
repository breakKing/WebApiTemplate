using System.Text.Json;
using FastEndpoints.Swagger;
using FastEndpointsTemplate.Endpoints;

namespace FastEndpointsTemplate.Configuration;

public static class ApplicationPipeline
{
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();
        
        app.UseFastEndpoints(config =>
        {
            config.Serializer.Options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            config.Endpoints.RoutePrefix = "api";
            
            config.Errors.ResponseBuilder = (failures, _, _) =>
            {
                return new ApiResponse<object>(
                    null, 
                    true,
                    failures.Select(f => $"{f.PropertyName}: {f.ErrorMessage}").ToList());
            };
        });

        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerGen();
        }
        
        return app;
    }
}