namespace FastEndpointsTemplate.Endpoints.Weather.Get;

public sealed class GetWeatherEndpoint : EndpointWithoutRequestBase<GetWeatherResponse>
{
    private readonly ILogger<GetWeatherEndpoint> _logger;

    public GetWeatherEndpoint(ILogger<GetWeatherEndpoint> logger)
    {
        _logger = logger;
    }

    /// <inheritdoc />
    public override void Configure()
    {
        Get();
        Group<WeatherEndpointGroup>();
        AllowAnonymous();

        ConfigureSwaggerDescription(
            new GetWeatherEndpointSummary(),
            HttpStatusCode.OK,
            HttpStatusCode.InternalServerError);
    }

    /// <inheritdoc />
    public override async Task HandleAsync(EmptyRequest req, CancellationToken ct)
    {
        var data = Enumerable.Range(1, 5)
            .Select(index => new WeatherDto
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = WeatherDto.Summaries[Random.Shared.Next(WeatherDto.Summaries.Length)]
            })
            .ToList();

        var response = new GetWeatherResponse(data);

        await SendDataAsync(response, ct: ct);
    }
}