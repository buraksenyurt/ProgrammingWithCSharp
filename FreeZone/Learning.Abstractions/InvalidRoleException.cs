namespace Learning.Abstractions;

public class InvalidRoleException
    :Exception
{
    public MemberRole Role { get; set; }
}
