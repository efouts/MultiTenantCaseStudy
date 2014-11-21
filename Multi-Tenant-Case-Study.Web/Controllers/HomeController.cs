using System;
using System.Web.Mvc;
using Multi_Tenant_Case_Study.Core;

namespace Multi_Tenant_Case_Study.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content(ConnectionFactory.GetConnection());
        }
    }
}