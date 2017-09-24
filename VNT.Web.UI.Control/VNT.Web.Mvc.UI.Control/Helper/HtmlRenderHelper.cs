using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace VNT.Web.Mvc.UI.Control.Models
{
    public static class HtmlRenderHelper
    {
        public static void RenderContainer(this HtmlHelper helper, Container container)
        {
            foreach (var control in container.Controls)
            {
                helper.RenderPartial(control.Type, control);
            }
        }
    }
}