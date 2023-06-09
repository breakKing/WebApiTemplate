namespace WebApiTemplate.Endpoints.Todo.GetOne;

public sealed class GetOneTodoEndpointSummary : EndpointSummaryBase
{
    private static readonly GetOneTodoResponse SuccessResponseExample =
        new GetOneTodoResponse(
            Guid.NewGuid(), 
            "Сделать дело", 
            "Сделать дело и идти гулять");
    
    public GetOneTodoEndpointSummary()
    {
        Summary = "Получение TODO по id";
        Description = "Получение TODO по заданному id. Если такого нет, то в ответ отправляется NotFound";
        
        AddSuccessResponseExample(HttpStatusCode.OK, SuccessResponseExample);
        AddFailResponseExamples(HttpStatusCode.NotFound, HttpStatusCode.InternalServerError);
    }
}