using AIRMDesktopUI.Models;
using System.Threading.Tasks;

namespace AIRMDesktopUI.Helpers
{
  public interface IAPIHelper
  {
    Task<AuthenticatedUser> Authenticate(string username, string password);
  }
}