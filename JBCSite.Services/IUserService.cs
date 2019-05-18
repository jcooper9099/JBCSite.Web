using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JBCSite.Infrastructure;
using JBCSite.Domain.Models;
using JBCSite.Auth.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using JBCSite.Dto;

namespace JBCSite.Services
{
    public interface IUserService
    {
        Task<UserDto> CreateUser(string UserName, string Email, string Password);

        UserDto GetUser(string Id);

        UserDto GetUserViaEmail(string Email);
    }
}
