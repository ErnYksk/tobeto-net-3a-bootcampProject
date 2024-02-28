using Core.Entities;


namespace Entity.Concretes;

public class User : BaseEntity<int>
{

    public string? Username { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }

    public string? NationalIdentity { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }



    public User()
    {

    }

    public User(int id, string username, string firstName, string lastName, DateTime dateOfBirth, string nationalIdentity, string email, string password)
    {
        Id = id;
        Username = username;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        NationalIdentity = nationalIdentity;
        Email = email;
        Password = password;
    }
}
