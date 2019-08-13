using System.Security.Principal;

namespace AcutrackFulfillment.Core.Interfaces
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
