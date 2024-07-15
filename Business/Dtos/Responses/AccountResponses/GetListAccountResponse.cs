namespace Business.Dtos.Responses.AccountResponses;

public class GetListAccountResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public string Email { get; set; }
}
