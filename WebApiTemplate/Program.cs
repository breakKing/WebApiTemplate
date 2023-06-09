using FastEndpointsTemplate.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Builder
builder.Configure();

// Services
builder.Services.ConfigureDependencyInjection(builder.Configuration);

var app = builder.Build();

// Middlewares
app.ConfigurePipeline();

app.Run();