namespace WebApiTemplate.Endpoints;

public sealed record PaginationResponse(
    long ItemsCount, 
    int PageNumber, 
    int PageSize, 
    int PagesCount);