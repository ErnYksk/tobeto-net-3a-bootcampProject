namespace Business.Request.Applicant;

public class CreateApplicantRequest
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public string Email { get; set; }
}
