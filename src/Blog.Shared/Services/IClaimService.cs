
namespace Blog.Shared.Services
{
    public interface IClaimService
    {
        string GetUserId();

        string GetClaim(string key);
    }
}