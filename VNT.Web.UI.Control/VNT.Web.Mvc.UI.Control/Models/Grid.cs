namespace VNT.Web.Mvc.UI.Control.Models
{
    public class Grid : IControl
    {
        public string Type
        {
            get { return "Grid"; }
        }

        public string WebApiUrl { get; set; }
    }
}