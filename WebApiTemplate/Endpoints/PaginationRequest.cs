using System.Text.Json.Serialization;

namespace FastEndpointsTemplate.Endpoints;

public sealed record PaginationRequest(
    [property: JsonPropertyName("pageNumber")] int PageNumber, 
    [property: JsonPropertyName("pageSize")] int PageSize);