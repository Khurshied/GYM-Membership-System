using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FMS.Filters;

namespace FMS.Controllers
{
    
    public class DashboardController : Controller
    {
       
        [MyExceptionHandler]
        [Authorize(Roles = "Admin")]
        public ActionResult AdminDashboard()
        {
            return View();
        }

        [MyExceptionHandler]
        [Authorize(Roles = "SystemUser")]
        public ActionResult UserDashboard()
        {
            return View();
        }

    }
}
