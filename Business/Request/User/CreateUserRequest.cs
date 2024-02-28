namespace Business.Request.User;

public class CreateUserRequest
{
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string NationalIdendity{ get; set; }
    public string EmailAddress { get; set; }
}
