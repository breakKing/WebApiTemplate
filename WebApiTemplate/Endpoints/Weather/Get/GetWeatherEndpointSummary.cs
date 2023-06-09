namespace WebApiTemplate.Endpoints.Weather.Get;

public sealed class GetWeatherEndpointSummary : EndpointSummaryBase
{
    private static readonly GetWeatherResponse SuccessResponseExample =
        new GetWeatherResponse(
            Enumerable.Range(1, 5)
                .Select(_ => new WeatherDto())
                .ToList());
    
    public GetWeatherEndpointSummary()
    {
        Summary = "Стандартный коробочный запрос погоды";
        Description = "Генерация пяти рандомных прогнозов погоды. Эндпоинт, идущий в шаблонах по умолчанию";
        
        AddSuccessResponseExample(HttpStatusCode.OK, SuccessResponseExample);
        AddFailResponseExamples(HttpStatusCode.InternalServerError);
    }
}