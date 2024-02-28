namespace Business.Request.User;

public class CreateUserRequest
{
    // id ye gerek yok, createTime zaten repo icinde verdik
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string NationalIdendity{ get; set; }
    public string EmailAddress { get; set; }
}
