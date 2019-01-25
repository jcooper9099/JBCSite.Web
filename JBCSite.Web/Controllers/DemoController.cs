using JBCSite.Services;
using JBCSite.Viewmodels;
using System.Linq;
using System.Web.Mvc;

namespace JBCSite.Web.Controllers
{
    public class DemoController : Controller
    {
        private DemoService _demoService = new DemoService();

        // GET: Demo
        public ActionResult Index()
        {
            var vm = new DemoListViewModel
            {
                InfoList = _demoService.GetSummaries().ToList()
            };

            return View(vm);
        }
    }
}