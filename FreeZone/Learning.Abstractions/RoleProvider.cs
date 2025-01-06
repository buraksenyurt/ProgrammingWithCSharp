namespace Learning.Abstractions;

public class RoleProvider(ILogger logger)
{
    private readonly ILogger _logger = logger;

    public bool IsAuthorized(Member member)
    {
        try
        {
            if (member.Role.Name == "Administrator")
            {
                _logger.Info($"{member.Role.Name} geçerli rolde");
                return true;
            }
            else if (member.Role.Name == "StandardUser")
            {
                _logger.Info($"{member.Role.Name} geçerli rolde");
                return true;
            }
            else
            {
                throw new InvalidRoleException { Role = member.Role };
            }
        }
        catch (Exception ex)
        {
            _logger.Error(ex.Message);
            // Console.WriteLine(ex.Message);
        }
        return false;
    }
}
