using System;
using System.Threading.Tasks;
using System.Web.Http;
using DotNetMsk._10.DemoTestProject.Contracts;

namespace DotNetMsk._10.DemoTestProject.Api
{
    public class TimeController : ApiController
    {
        [HttpPost]
        [Route("get_time_passed")]
        public async Task<TimePassedResponse> GetTimePassedAsync(TimePassedRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
