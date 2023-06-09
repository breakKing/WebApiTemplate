namespace WebApiTemplate.Endpoints;

public record ApiResponse<TData>(TData? Data, bool Failed, List<string>? Errors);