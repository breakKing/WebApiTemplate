﻿namespace FastEndpointsTemplate.Endpoints.Weather.Get;

public sealed record GetWeatherResponse(List<WeatherDto> Items);