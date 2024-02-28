namespace Business.Request.Applicant;

public class UpdateApplicantRequest
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    public string Email { get; set; }
}
