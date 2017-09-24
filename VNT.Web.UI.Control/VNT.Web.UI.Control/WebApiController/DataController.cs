using System.Web.Http;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using VNT.Web.UI.Control.Models;

namespace VNT.Web.UI.Control.WebApiController
{
    public class DataController : ApiController
    {
        public DataSourceResult GetCustomers([System.Web.Http.ModelBinding.ModelBinder(typeof(WebApiDataSourceRequestModelBinder))]DataSourceRequest request)
        {
            var result = new[]
            {
                new Customer
                {
                    Name = "Giang",
                    Age = 23
                },
                new Customer
                {
                    Name = "Thao",
                    Age = 25
                }
            };
            return result.ToDataSourceResult(request);
        }
    }
}
