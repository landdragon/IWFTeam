using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OWINTest.Service.API
{
    [RoutePrefix("api/testing2")]
    public class Routed2Controller : ApiController
    {
        [Route("v1/getall")]
        public IEnumerable<string> GetAllItemsv1()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("getall")]
        public IEnumerable<string> GetAllItems()
        {
            return new string[] { "value1", "value2" };
        }
    }
}