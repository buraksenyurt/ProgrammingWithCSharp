namespace Learning.Abstractions;

internal class Program
{
    static void Main()
    {
        var consoleLogger = new ConsoleLogger();
        var roleProvider = new RoleProvider(consoleLogger);
        var member = new Member()
        {
            Id = 1,
            Role = new MemberRole
            {
                Name = "Hacker",
                Description = "All roles"
            },
            Created = DateTime.UtcNow.AddYears(-1),
            Fullname = "Mario Bross",
            LastLogin = DateTime.UtcNow.AddDays(1),
        };
        var authorized = roleProvider.IsAuthorized(member);
        Console.WriteLine(authorized);
    }
}
