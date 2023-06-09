namespace WebApiTemplate.Endpoints.Todo.GetMany;

public sealed class GetManyTodoEndpointSummary : EndpointSummaryBase
{
    private static readonly PaginatedData<TodoManyDto> SuccessResponseExample =
        new PaginatedData<TodoManyDto>(
            new List<TodoManyDto>()
            {
                new(Guid.NewGuid(), "Сделать описание"),
                new(Guid.NewGuid(), "Создать эндпоинт")
            },
            new PaginationResponse(100, 1, 2, 50));
    
    public GetManyTodoEndpointSummary()
    {
        Summary = "Запрос пагинированного списка TODO с фильтрами";
        Description = "Запрос пагинированного списка TODO со строковым фильтром по названию";
        
        AddSuccessResponseExample(HttpStatusCode.OK, SuccessResponseExample);
        AddFailResponseExamples(HttpStatusCode.BadRequest, HttpStatusCode.InternalServerError);
    }
}