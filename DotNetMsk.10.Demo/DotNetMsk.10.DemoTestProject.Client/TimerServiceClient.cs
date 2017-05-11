using System;
using System.Threading.Tasks;

namespace DotNetMsk._10.DemoTestProject.Client
{
    public class TimerServiceClient : ITimerServiceClient
    {
        #region private properties

        private readonly Uri _baseUrl;
        private const string GetTimePassedRoute = "get_time_passed";

        #endregion

        public TimerServiceClient(string baseUrl)
        {
            throw new NotImplementedException();
        }

        public Task<TimeSpan> GetTimePassedTillDateAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<TimeSpan> GetTimePassedTillDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<TimeSpan> GetTimePassedTillNowAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TimeSpan> GetTimePassedTillNow()
        {
            throw new NotImplementedException();
        }
    }
}