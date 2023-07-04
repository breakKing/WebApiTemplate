namespace WebApiTemplate.Endpoints.Todo.GetOne;

public sealed class GetOneTodoEndpoint : EndpointBase<GetOneTodoRequest, GetOneTodoResponse>
{
    /// <inheritdoc />
    public override void Configure()
    {
        Get("{Id}");
        Group<TodoEndpointGroup>();
        AllowAnonymous();

        ConfigureSwaggerDescription(
            new GetOneTodoEndpointSummary(),
            HttpStatusCode.OK,
            HttpStatusCode.NotFound,
            HttpStatusCode.InternalServerError);
    }

    /// <inheritdoc />
    public override async Task HandleAsync(GetOneTodoRequest req, CancellationToken ct)
    {
        var data = new GetOneTodoResponse(
            req.Id,
            "Сделать дело",
            "Сделать дело и идти гулять");

        await SendDataAsync(data, ct: ct);
    }
}