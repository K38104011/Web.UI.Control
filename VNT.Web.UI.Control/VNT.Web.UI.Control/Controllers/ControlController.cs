using System.Collections.Generic;
using System.Web.Mvc;
using VNT.Web.UI.Control.ControlConfiguration;

namespace VNT.Web.UI.Control.Controllers
{
    public class ControlController : Controller
    {
        public ActionResult Grid()
        {
            var model = new Grid
            {
                WebApiUrl = Url.Content(@"~/api/Data/GetCustomers")
            };
            return View(model);
        }
    }
}