namespace Business.Request.Application;

public class CreateApplicationRequest
{
    public int ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public int ApplicationStateId { get; set; }

}
