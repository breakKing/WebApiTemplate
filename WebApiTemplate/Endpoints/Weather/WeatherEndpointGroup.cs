namespace WebApiTemplate.Endpoints.Weather;

public sealed class WeatherEndpointGroup : EndpointGroupBase
{
    /// <inheritdoc />
    public WeatherEndpointGroup() : base("Weather", "weather")
    {
    }
}