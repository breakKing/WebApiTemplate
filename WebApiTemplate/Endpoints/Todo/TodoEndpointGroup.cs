namespace WebApiTemplate.Endpoints.Todo;

public sealed class TodoEndpointGroup : EndpointGroupBase
{
    /// <inheritdoc />
    public TodoEndpointGroup() : base("TODOs", "todo")
    {
    }
}