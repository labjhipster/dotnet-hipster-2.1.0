using System.Security.Authentication;

namespace HumanResources.Crosscutting.Exceptions
{
    public class UsernameNotFoundException : AuthenticationException
    {
        public UsernameNotFoundException(string message) : base(message)
        {
        }
    }
}
