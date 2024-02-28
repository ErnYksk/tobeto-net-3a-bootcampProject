namespace Entity.Concretes;

public class Instructor : User
{
    public string CompanyName { get; set; }


    public virtual ICollection<Bootcamp> Bootcamps { get; set; }
    public Instructor()
    {
        Bootcamps = new HashSet<Bootcamp>();
    }

    public Instructor(int id, int instructorId, string companyName)
    {
        Id = id;
        CompanyName = companyName;
    }
}
