using JBCSite.Auth;
using JBCSite.Auth.Models;
using JBCSite.Dto;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JBCSite.Services
{
    public class UserService : IDisposable, IUserService
    {
        private bool _disposed;        
        private AuthContext _authContext = new AuthContext();
        private UserManager<IdentityUser> _userManager;

        public UserService()
        {
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_authContext));
        }

        public async Task<UserDto> CreateUser(string UserName, string Email, string Password)
        {
            var appUser = new IdentityUser
            {
                UserName = UserName,
                Email = Email
            };

            var identResult = await _userManager.CreateAsync(appUser, Password);

            if (identResult.Succeeded)
            {
                var user=  _authContext.Users.FirstOrDefault(x => x.Email == Email);
                return new UserDto
                {
                    UserName = user.UserName,
                    Email = user.Email
                };
            }

            return null;
        }

        public UserDto GetUser(string Id)
        {
            var user =  _authContext.Users.FirstOrDefault(x => x.Id == Id);
            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email
            };
        }

        public UserDto GetUserViaEmail(string Email)
        {
            var user = _authContext.Users.FirstOrDefault(x => x.Email.Equals(Email, StringComparison.OrdinalIgnoreCase));

            return new UserDto
            {
                UserName = user.UserName,
                Email = user.Email
            };
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _authContext.Dispose();
                }

                _disposed = true;
            }
        }       
    }
}
