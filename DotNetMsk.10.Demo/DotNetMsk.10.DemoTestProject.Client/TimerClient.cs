using System;
using System.Threading.Tasks;

namespace DotNetMsk._10.DemoTestProject.Client
{
    public class TimerClient : ITimerClient
    {
        private readonly Uri _baseUrl;
        private const string GetTimePassedRoute = "get_time_passed";

        public TimerClient(string baseUrl)
        {
            _baseUrl = new Uri(baseUrl);
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