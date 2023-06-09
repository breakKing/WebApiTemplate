namespace FastEndpointsTemplate.Endpoints.Weather.Get;

public sealed class GetWeatherEndpointSummary : EndpointSummaryBase
{
    private static readonly GetWeatherResponse _successResponseExample =
        new GetWeatherResponse(
            Enumerable.Range(1, 5)
                .Select(_ => new WeatherDto())
                .ToList());
    
    public GetWeatherEndpointSummary()
    {
        Summary = "Стандартный коробочный запрос погоды";
        Description = "Генерация пяти рандомных прогнозов погоды. Эндпоинт, идущий в шаблонах по умолчанию";
        
        AddSuccessResponseExample(HttpStatusCode.Created, _successResponseExample);
        AddFailResponseExamples(HttpStatusCode.InternalServerError);
    }
}