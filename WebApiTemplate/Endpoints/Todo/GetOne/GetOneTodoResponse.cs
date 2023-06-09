namespace WebApiTemplate.Endpoints.Todo.GetOne;

public sealed record GetOneTodoResponse(Guid Id, string Name, string? Description);