namespace Learning.Abstractions;

public class Member
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime Created { get; set; }
    public MemberRole Role { get; set; }
}
