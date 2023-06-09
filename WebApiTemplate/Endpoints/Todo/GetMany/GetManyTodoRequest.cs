namespace WebApiTemplate.Endpoints.Todo.GetMany;

public sealed record GetManyTodoRequest(
    string? Filter,
    int PageNumber,
    int PageSize) : PaginationRequest(PageNumber, PageSize);