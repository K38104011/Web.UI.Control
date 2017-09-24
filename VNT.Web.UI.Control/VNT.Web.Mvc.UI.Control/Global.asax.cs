using System.Web.Mvc;

namespace VNT.Web.Mvc.UI.Control
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
        }
    }
}
