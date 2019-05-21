using JBCSite.Dto;
using System.Threading.Tasks;

namespace JBCSite.Services
{
    public interface IUserService
    {
        Task<UserDto> CreateUser(string UserName, string Email, string Password);

        UserDto GetUser(string Id);

        UserDto GetUserViaEmail(string Email);
    }
}
