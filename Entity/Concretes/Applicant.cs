namespace Entity.Concretes;

public class Applicant : User
{

    public string About { get; set; }

    
    public ICollection<Application> Applications { get; set; }

    public virtual BlackList? BlackList { get; set; }


    public Applicant()
    {
        Applications = new HashSet<Application>();

    }

    public Applicant(int id, int applicantId, string about)
    {
        Id = id;
        About = about;
    }

}
