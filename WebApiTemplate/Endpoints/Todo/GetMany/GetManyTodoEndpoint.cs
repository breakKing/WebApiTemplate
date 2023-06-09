namespace WebApiTemplate.Endpoints.Todo.GetMany;

public sealed class GetManyTodoEndpoint : EndpointWithPaginationBase<GetManyTodoRequest, TodoManyDto>
{
    /// <inheritdoc />
    public override void Configure()
    {
        Get("");
        Group<TodoEndpointGroup>();
        AllowAnonymous();

        ConfigureSwaggerDescription(
            new GetManyTodoEndpointSummary(),
            HttpStatusCode.OK,
            HttpStatusCode.BadRequest,
            HttpStatusCode.InternalServerError);
    }
    
    /// <inheritdoc />
    public override async Task HandleAsync(GetManyTodoRequest req, CancellationToken ct)
    {
        var data = new List<TodoManyDto>()
        {
            new(Guid.NewGuid(), "Сделать описание"),
            new(Guid.NewGuid(), "Создать эндпоинт")
        };

        var paginationResponse = new PaginationResponse(100, 1, 2, 50);

        var paginatedData = new PaginatedData<TodoManyDto>(data, paginationResponse);

        await SendDataAsync(paginatedData, ct: ct);
    }
}