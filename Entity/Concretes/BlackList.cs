using Core.Entities;

namespace Entity.Concretes;

public class BlackList : BaseEntity<int>
{
    public string Reason { get; set; }
    public DateTime? Date { get; set; }
    public int? ApplicantId { get; set; }
    public virtual Applicant? Applicant { get; set; }

    public BlackList()
    {
    }

    public BlackList(int id, string reason, DateTime date, int applicantId)
    {
        Id = id;
        Reason = reason;
        Date = date;
        ApplicantId = applicantId;
    }
}
