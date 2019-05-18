using JBCSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JBCSite.Web.ViewModels;
using System.Threading.Tasks;
using JBCSite.Dto;

namespace JBCSite.Web.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        // GET: User
        public ActionResult Index()
        {
            var vm = new CreateUserViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateUserViewModel vm)
        {
            var user = await _userService.CreateUser(vm.UserName, vm.Email, vm.Password);
            

            return View("CreateComplete",user);
        }
    }
}